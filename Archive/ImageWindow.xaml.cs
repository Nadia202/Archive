using PdfSharp.Drawing;
using PdfSharp.Pdf;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace Archive
{
    /// <summary>
    /// Логика взаимодействия для ImageWindow.xaml
    /// </summary>
    public partial class ImageWindow : Window
    {
        DBPP dbpp;
        Documents d;
        int page;
        int pageMax;
        public ImageWindow(DBPP dbpp, Documents d)
        {
            InitializeComponent();
            this.dbpp = dbpp;
            this.d = d;
            page = 1;
            pageMax = dbpp.Pages.Where(p => p.document == d.id).OrderBy(n => n.page).ToList().Count;
            update(page);
        }

        void update(int pg)
        {
            var pages = dbpp.Pages.Where(p => p.document == d.id).OrderBy(n => n.page).Skip(pg - 1);
            this.DataContext = pages.First();
            string info = $"{pg} из {pageMax}";
            infTextBox.Text = info;
        }

        private void btnBack_Click(object sender, RoutedEventArgs e)
        {
            if (page == 1)
            {
                return;
            }
            page--;
            update(page);
        }

        private void btnNext_Click(object sender, RoutedEventArgs e)
        {
            if (page == pageMax)
            {
                return;
            }
            page++;
            update(page);
        }

        private void btnDoc_Click(object sender, RoutedEventArgs e)
        {
            var pages = dbpp.Pages.Where(page => page.document == d.id).OrderBy(n => n.page);
            PdfDocument doc = new PdfDocument();
            for (int i = 0; i < pages.Count(); i++)
            {
                Pages page = pages.Skip(i).First();
                byte[] imageByte = page.photo;
                MemoryStream ms = new MemoryStream(imageByte);
                doc.Pages.Add(new PdfPage());
                XGraphics xgr = XGraphics.FromPdfPage(doc.Pages[i]);
                XImage xImage = XImage.FromStream(ms);
                xgr.DrawImage(xImage, 0, 0, 595, 842);
            }
            String filename = "Документ.pdf";
            doc.Save(filename);
            Process.Start(filename);
        }
    }
}
