using System;
using System.Collections.Generic;
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

namespace PP
{
    /// <summary>
    /// Логика взаимодействия для PageSearch.xaml
    /// </summary>
    public partial class PageSearch : Page
    {
        DBPP dbpp;
        public PageSearch()
        {
            InitializeComponent();
            dbpp = new DBPP();
            OrganizationDataGrid.ItemsSource = dbpp.Organizations.ToList();
            if (PageAuthorization.user.position == 0)
            {
                btnUsersList.Visibility = Visibility.Visible;
            }
        }
        private void btnExit_Click(object sender, RoutedEventArgs e)
        {
            this.NavigationService.Navigate(new Uri("PageAuthorization.xaml", UriKind.Relative));
        }
        private void searchOrgTextBox_TextChanged (object sender, TextChangedEventArgs e)
        {
            OrganizationDataGrid.ItemsSource = dbpp.Organizations.Where(w => w.name.StartsWith(searchOrgTextBox.Text)).ToList();
        }
        private void btnAddOrganization_Click(object sender, RoutedEventArgs e)
        {
            Organizations organization = new Organizations();
            PageAddOrganization p = new PageAddOrganization(dbpp, organization, false);
            NavigationService.Navigate(p);
        }
        private void btnUpdateOrganization_Click(object sender, RoutedEventArgs e)
        {
            Organizations organization = OrganizationDataGrid.SelectedItem as Organizations;
            PageAddOrganization p = new PageAddOrganization(dbpp, organization, true);
            NavigationService.Navigate(p);
        }
        private void btnUsersList_Click(object sender, RoutedEventArgs e)
        {
            listBoxUsers.ItemsSource = dbpp.Users.Where(w => w.position != 0).Where( w => w.lastName.StartsWith(searchTextBox.Text) || w.firstName.StartsWith(searchTextBox.Text) || w.patronymic.StartsWith(searchTextBox.Text)).OrderBy(order => order.adopted).ThenBy(order => order.position).ToList();
            if (borederUserList.Visibility == Visibility.Collapsed)
                borederUserList.Visibility = Visibility.Visible;
            else
                borederUserList.Visibility = Visibility.Collapsed;
        }

        private void adoptedUser_Click(object sender, RoutedEventArgs e)
        {
            Users user = (sender as FrameworkElement).DataContext as Users;
            user.adopted = (bool)(sender as CheckBox).IsChecked;
            dbpp.SaveChanges();
            listBoxUsers.ItemsSource = dbpp.Users.Where(w => w.position != 0).Where(w => w.lastName.StartsWith(searchTextBox.Text) || w.firstName.StartsWith(searchTextBox.Text) || w.patronymic.StartsWith(searchTextBox.Text)).OrderBy(order => order.adopted).ThenBy(order => order.position).ToList();
        }

        private void searchTextBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            listBoxUsers.ItemsSource = dbpp.Users.Where(w => w.position != 0).Where(w => w.lastName.StartsWith(searchTextBox.Text) || w.firstName.StartsWith(searchTextBox.Text) || w.patronymic.StartsWith(searchTextBox.Text)).OrderBy(order => order.adopted).ThenBy(order => order.position).ToList();
        }

        private void OrganizationDataGrid_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            btnUpdateOrganization.IsEnabled = true;
        }

        private void DataGridRow_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            Organizations organization = OrganizationDataGrid.SelectedItem as Organizations;
            PageOrganization p = new PageOrganization(organization);
            NavigationService.Navigate(p);
        }
    }
}
