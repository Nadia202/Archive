using Microsoft.Win32;
using System;
using System.Collections.Generic;
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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Archive
{
    public partial class PageAddDocument : Page
    {
        DBPP dbpp;
        Organizations organization;
        Documents d;
        bool b;
        public PageAddDocument(DBPP dbpp, Organizations organization, Documents d, bool b)
        {
            InitializeComponent();
            this.dbpp = dbpp;
            var type = dbpp.TypeDocument.Join(dbpp.DocumentPosition.Where(pos => pos.position == PageAuthorization.user.position),
                t => t.id,
                p => p.typeDocument,
                (t,p) => new
                {
                    t.id,
                    t.type
                } ).OrderBy(i => i.id).ToList();
            for (int i = 0; i < type.Count; i++)
            {
                typeComboBox.Items.Add(type.Skip(i).First().type);
            }
            this.d = d;
            this.organization = organization;
            this.b = b;
            this.DataContext = d;
            if (b)
            {
                datePicker.Text = d.date.ToString();
                typeComboBox.SelectedIndex = d.type;
                btnAddPage.IsEnabled = true;
                UpdateList();
            }
        }
        
        private void UpdateList()
        {
            listBoxAddPage.ItemsSource = dbpp.Pages.Where(x => x.document == d.id).OrderBy(o => o.page).ToList();
        }

        private void btnExit_Click_1(object sender, RoutedEventArgs e)
        {
            PageOrganization p = new PageOrganization(organization);
            NavigationService.Navigate(p);
        }

        private void btnAddPage_Click(object sender, RoutedEventArgs e)
        {
            if (numberPageTextBox.Text == "")
            {
                MaterialDesignThemes.Wpf.HintAssist.SetHelperText(numberPageTextBox, "Пусто");
                return;
            }
            int number = Convert.ToInt16(numberPageTextBox.Text);
            var n = dbpp.Pages.Where(x => x.document == d.id && x.page == number).ToList();
            if (n.Count() > 0)
            {
                return;
            }
            OpenFileDialog openFile = new OpenFileDialog();
            openFile.Filter = "Картинка форматов jpg, png|*.jpg; *.png";
            openFile.ShowDialog();
            if (openFile.FileName.Length != 0)
            {
                string nameFile = openFile.FileName;
                byte[] image = File.ReadAllBytes(nameFile);
                Pages p = new Pages
                {
                    document = d.id,
                    page = Convert.ToInt16(numberPageTextBox.Text),
                    photo = image
                };
                dbpp.Pages.Add(p);
                dbpp.SaveChanges();
            }
            numberPageTextBox.Text = "";
            UpdateList();
        }

        private void btnCreate_Click(object sender, RoutedEventArgs e)
        {
            if (typeComboBox.SelectedIndex == -1)
            {
                MaterialDesignThemes.Wpf.HintAssist.SetHelperText(typeComboBox, "Поле не заполнено");
                return;
            }
            else
                MaterialDesignThemes.Wpf.HintAssist.SetHelperText(typeComboBox, "");

            if (datePicker.Text == "")
            {
                MaterialDesignThemes.Wpf.HintAssist.SetHelperText(datePicker, "Поле не заполнено");
                return;
            }
            else
                MaterialDesignThemes.Wpf.HintAssist.SetHelperText(typeComboBox, "");

            d.organization = organization.id;

            var type = dbpp.TypeDocument.Join(dbpp.DocumentPosition.Where(pos => pos.position == PageAuthorization.user.position),
                t => t.id,
                p => p.typeDocument,
                (t, p) => new
                {
                    t.id,
                    t.type
                }).OrderBy(i => i.id).ToList();

            d.type = type.Skip(typeComboBox.SelectedIndex).First().id;

            d.date = Convert.ToDateTime(datePicker.Text);
            if (!b)
            {
                dbpp.Documents.Add(d);
                btnAddPage.IsEnabled = true;
                btnCreate.IsEnabled = false;
                typeComboBox.IsEnabled = false;
                datePicker.IsEnabled = false;
            }
            dbpp.SaveChanges();
        }

        private void delPageBtn_Click(object sender, RoutedEventArgs e)
        {
            var item = (sender as FrameworkElement).DataContext;
            int index = listBoxAddPage.Items.IndexOf(item);
            if (index >= 0)
            {
                Pages p = dbpp.Pages.Where(w => w.document == d.id).OrderBy(o => o.page).Skip(index).First();
                dbpp.Pages.Remove(p);
                dbpp.SaveChanges();
                UpdateList();
            }
        }

        private void numberPageTextBox_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            if (!Char.IsDigit(e.Text, 0))
            {
                e.Handled = true;
            }
        }

        private void Image_MouseDown(object sender, MouseButtonEventArgs e)
        {

        }
    }
}