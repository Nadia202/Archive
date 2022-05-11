using System;
using System.Linq;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;

namespace PP
{
    public partial class PageSearch : Page
    {
        DBPP dbpp;
        long idOrg;
        public PageSearch(long idOrg)
        {
            InitializeComponent();
            dbpp = new DBPP();
            if (idOrg != 0)
            {
                innTextBox.Text = idOrg.ToString();
            }
            if (PageAuthorization.user.position == 0)
            {
                btnUsersList.Visibility = Visibility.Visible;
            }
        }

        private void btnExit_Click(object sender, RoutedEventArgs e)
        {
            this.NavigationService.Navigate(new Uri("PageAuthorization.xaml", UriKind.Relative));
        }

        private void innTextBox_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            if (!Char.IsDigit(e.Text,0))
            {
                e.Handled = true;
            }
        }

        private void btnAddOrganization_Click(object sender, RoutedEventArgs e)
        {
            Organizations organization = new Organizations();
            PageAddOrganization p = new PageAddOrganization(dbpp,organization,false);
            NavigationService.Navigate(p);
        }

        private void btnUpdateOrganization_Click(object sender, RoutedEventArgs e)
        {
            Organizations organization = (from org in dbpp.Organizations where org.id == idOrg select org).ToList().First();
            PageAddOrganization p = new PageAddOrganization(dbpp,organization,true);
            NavigationService.Navigate(p);
        }

        private void innTextBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (innTextBox.Text == "")
            {
                MaterialDesignThemes.Wpf.HintAssist.SetHelperText(innTextBox, "");
                return;
            }
            idOrg = Convert.ToInt64(innTextBox.Text);
            Organizations o = new Organizations();
            if (idOrg.ToString().Length < 10)
            {
                MaterialDesignThemes.Wpf.HintAssist.SetHelperText(innTextBox, "Введите ИНН полностью");
                infoOrgTextBlock.Text = "";
                btnAddDocument.IsEnabled = false;
                btnUpdateOrganization.IsEnabled = false;
                listBoxDoc.ItemsSource = null;
                return;
            }
            o = (from org in dbpp.Organizations where org.id == idOrg select org).ToList().FirstOrDefault();
            if ( o == null )
            {
                MaterialDesignThemes.Wpf.HintAssist.SetHelperText(innTextBox, "Организации с таким ИНН нет");
                return;
            }
            btnAddDocument.IsEnabled = true;
            btnUpdateOrganization.IsEnabled = true;
            MaterialDesignThemes.Wpf.HintAssist.SetHelperText(innTextBox, "");
            var opf = dbpp.TypeOPF.Where(t => t.id == o.opf).ToList().First();
            infoOrgTextBlock.Text = opf.type + "\"" + o.name + "\"" + "\n" + "Руководитель: " + o.director + "\n" + "Зарегистрирован по адресу: " + o.address + "\n" + "КПП: " + o.kpp + "\n" + "ОГРН: " + o.ogrn;

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
                             }).Where(d => d.organization == idOrg).OrderBy(or => or.id).ToList();
            listBoxDoc.ItemsSource = documents;
        }

        private void btnAddDocument_Click(object sender, RoutedEventArgs e)
        {
            Documents d = new Documents();
            PageAddDocument p = new PageAddDocument(dbpp,idOrg,d,false);
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
                                 }).Where(doc => doc.organization == idOrg).OrderBy(or => or.id).Skip(index).FirstOrDefault();
                Documents d = dbpp.Documents.Where(w => w.id == documents.id).First();
                PageAddDocument p = new PageAddDocument(dbpp, idOrg, d, true);
                NavigationService.Navigate(p);
            }
        }

        private void btnUsersList_Click(object sender, RoutedEventArgs e)
        {
            listBoxUsers.ItemsSource = dbpp.Users.Where(w => w.lastName.StartsWith(searchTextBox.Text) || w.firstName.StartsWith(searchTextBox.Text) || w.patronymic.StartsWith(searchTextBox.Text)).OrderBy(order => order.adopted).ThenBy(order => order.position).ToList();
            if (borederUserList.Visibility == Visibility.Hidden)
                borederUserList.Visibility = Visibility.Visible;
            else
                borederUserList.Visibility = Visibility.Hidden;
        }

        private void adoptedUser_Click(object sender, RoutedEventArgs e)
        {
            Users user = (sender as FrameworkElement).DataContext as Users;
            user.adopted = (bool)(sender as CheckBox).IsChecked;
            dbpp.SaveChanges();
            listBoxUsers.ItemsSource = dbpp.Users.Where(w => w.lastName.StartsWith(searchTextBox.Text) || w.firstName.StartsWith(searchTextBox.Text) || w.patronymic.StartsWith(searchTextBox.Text)).OrderBy(order => order.adopted).ThenBy(order => order.position).ToList();
        }

        private void searchTextBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            listBoxUsers.ItemsSource = dbpp.Users.Where(w => w.lastName.StartsWith(searchTextBox.Text) || w.firstName.StartsWith(searchTextBox.Text) || w.patronymic.StartsWith(searchTextBox.Text) ).OrderBy(order => order.adopted).ThenBy(order => order.position).ToList();
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
                                 }).Where(doc => doc.organization == idOrg).OrderBy(or => or.id).Skip(index).FirstOrDefault();
                Documents d = dbpp.Documents.Where(w => w.id == documents.id).First();
                ImageWindow imageWindow = new ImageWindow(dbpp,d);
                imageWindow.ShowDialog();
            }
        }
    }  
}
