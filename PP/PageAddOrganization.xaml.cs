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
    public partial class PageAddOrganization : Page
    {
        DBPP dbpp;
        Organizations o;
        bool b;
        public PageAddOrganization(DBPP dbpp,Organizations o, bool b)
        {
            InitializeComponent();
            this.dbpp = dbpp;
            this.b = b;
            this.o = o;
            if (b)
            {
                this.DataContext = o;
                opfComboBox.SelectedIndex = o.opf;
                innTextBox.IsEnabled = false;
            }
            opfComboBox.ItemsSource = dbpp.TypeOPF.ToList();
        }

        private void btnSave_Click(object sender, RoutedEventArgs e)
        {
            bool empty = true;

            if (innTextBox.Text == "" || innTextBox.Text.Length < 10)
            {
                MaterialDesignThemes.Wpf.HintAssist.SetHelperText(innTextBox, "Поле не заполнено");
                empty = false;
            }
            else
                MaterialDesignThemes.Wpf.HintAssist.SetHelperText(innTextBox, "");

            TextBox[] textBoxes = { directorTextBox, nameTextBox, kppTextBox, ogrnTextBox, addressTextBox };
            foreach (TextBox textBox in textBoxes)
            {
                if (string.IsNullOrWhiteSpace(textBox.Text))
                {
                    MaterialDesignThemes.Wpf.HintAssist.SetHelperText(textBox, "Поле не заполнено");
                    empty = false;
                }
                else
                    MaterialDesignThemes.Wpf.HintAssist.SetHelperText(textBox, "");
            }

            if (opfComboBox.SelectedIndex == -1)
            {
                MaterialDesignThemes.Wpf.HintAssist.SetHelperText(opfComboBox, "Поле не выбрано");
                empty = false;
            }
            else
                MaterialDesignThemes.Wpf.HintAssist.SetHelperText(opfComboBox, "");

            if (empty)
            {
                o.opf = opfComboBox.SelectedIndex;
                o.name = nameTextBox.Text;
                o.kpp = Convert.ToInt64(kppTextBox.Text);
                o.ogrn = Convert.ToInt64(ogrnTextBox.Text);
                o.address = addressTextBox.Text;
                o.director = directorTextBox.Text;
                if (!b)
                {
                    dbpp.Organizations.Add(o);
                }
                dbpp.SaveChanges();
                PageOrganization p = new PageOrganization(o);
                NavigationService.Navigate(p);
                return;
            }
        }

        private void number_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            if (!Char.IsDigit(e.Text, 0))
            {
                e.Handled = true;
            }
        }

        private void btnExit_Click(object sender, RoutedEventArgs e)
        {
            PageSearch p = new PageSearch();
            NavigationService.Navigate(p);
        }
    }
}
