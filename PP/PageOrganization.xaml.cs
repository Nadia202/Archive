using System;
using System.Linq;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;

namespace PP
{
    public partial class PageOrganization : Page
    {
        DBPP dbpp;
        Organizations organization;
        public PageOrganization(Organizations organization)
        {
            InitializeComponent();
            dbpp = new DBPP();
            this.organization = organization;

            var opf = dbpp.TypeOPF.Where(t => t.id == organization.opf).ToList().First();
            infoOrgTextBlock.Text = opf.type + "\"" + organization.name + "\"" + "\n" + "Руководитель: " + organization.director + "\n" + "Зарегистрирован по адресу: " + organization.address + "\n" + "КПП: " + organization.kpp + "\n" + "ОГРН: " + organization.ogrn;

            var documents = (from d in dbpp.Documents
                             join p in dbpp.Pages on d.id equals p.document
                             where p.page == 1
                             join t in dbpp.TypeDocument on d.type equals t.id
                             join dp in dbpp.DocumentPosition on t.id equals dp.typeDocument
                             where dp.position == PageAuthorization.user.position
                             select new
                             {
                                 id = d.id,
                                 type = t.type,
                                 organization = d.organization,
                                 date = d.date,
                                 photo = p.photo
                             }).Where(d => d.organization == organization.id).OrderBy(or => or.id).ToList();
            listBoxDoc.ItemsSource = documents;
        }
        private void btnAddDocument_Click(object sender, RoutedEventArgs e)
        {
            Documents d = new Documents();
            PageAddDocument p = new PageAddDocument(dbpp, organization, d,false);
            NavigationService.Navigate(p);
        }
        private void editDocBtn_Click(object sender, RoutedEventArgs e)
        {
            var item = (sender as FrameworkElement).DataContext;
            int index = listBoxDoc.Items.IndexOf(item);
            if (index >= -1)
            {
                var documents = (from doc in dbpp.Documents
                                 join pag in dbpp.Pages on doc.id equals pag.document
                                 where pag.page == 1
                                 join t in dbpp.TypeDocument on doc.type equals t.id
                                 join dp in dbpp.DocumentPosition on t.id equals dp.typeDocument
                                 where dp.position == PageAuthorization.user.position
                                 select new
                                 {
                                     id = doc.id,
                                     type = t.type,
                                     organization = doc.organization,
                                     date = doc.date,
                                     photo = pag.photo
                                 }).Where(doc => doc.organization == organization.id).OrderBy(or => or.id).Skip(index).FirstOrDefault();
                Documents d = dbpp.Documents.Where(w => w.id == documents.id).First();
                PageAddDocument p = new PageAddDocument(dbpp, organization, d, true);
                NavigationService.Navigate(p);
            }
        }
        private void Image_MouseDown(object sender, MouseButtonEventArgs e)
        {
            var item = (sender as FrameworkElement).DataContext;
            int index = listBoxDoc.Items.IndexOf(item);
            if (index >= -1)
            {
                var documents = (from doc in dbpp.Documents
                                 join p in dbpp.Pages on doc.id equals p.document
                                 where p.page == 1
                                 join t in dbpp.TypeDocument on doc.type equals t.id
                                 join dp in dbpp.DocumentPosition on t.id equals dp.typeDocument
                                 where dp.position == PageAuthorization.user.position
                                 select new
                                 {
                                     id = doc.id,
                                     type = t.type,
                                     organization = doc.organization,
                                     date = doc.date,
                                     photo = p.photo
                                 }).Where(doc => doc.organization == organization.id).OrderBy(or => or.id).Skip(index).FirstOrDefault();
                Documents d = dbpp.Documents.Where(w => w.id == documents.id).First();
                ImageWindow imageWindow = new ImageWindow(dbpp,d);
                imageWindow.ShowDialog();
            }
        }
        private void btnExit_Click(object sender, RoutedEventArgs e)
        {
            PageSearch p = new PageSearch();
            NavigationService.Navigate(p);
        }
    }  
}
