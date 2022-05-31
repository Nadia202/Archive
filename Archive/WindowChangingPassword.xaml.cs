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
using System.Windows.Shapes;

namespace Archive
{
    /// <summary>
    /// Логика взаимодействия для WindowChangingPassword.xaml
    /// </summary>
    public partial class WindowChangingPassword : Window
    {
        DBPP dbpp;
        Users user;
        public WindowChangingPassword(DBPP dbpp, Users user)
        {
            InitializeComponent();
            this.dbpp = dbpp;
            this.user = user;
            UserInfoTextBlock.Text = $"{user.lastName} {user.firstName} {user.patronymic}";
        }

        private void btnSave_Click(object sender, RoutedEventArgs e)
        {
            if (String.IsNullOrWhiteSpace(NewPasswordTextBox.Text))
            {
                MaterialDesignThemes.Wpf.HintAssist.SetHelperText(NewPasswordTextBox,"Поле не заполнено");
                return;
            }
            else
            {
                MaterialDesignThemes.Wpf.HintAssist.SetHelperText(NewPasswordTextBox, "");
                user.password = NewPasswordTextBox.Text;
                dbpp.SaveChanges();
                this.Close();
            }
        }
    }
}
