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
using MaterialDesignThemes.Wpf;
using MaterialDesignColors;
using System.Threading;

namespace PP
{
    public partial class PageAuthorization : Page
    {
        DBPP pp;
        public static Users user;
        bool bAuthorization = true;
        public PageAuthorization()
        {
            InitializeComponent();
            pp = new DBPP();
            positionComboBox.ItemsSource = pp.PositionUsers.Where(p => p.id != 0).ToList();
        }

        private async void btnEnter_Click(object sender, RoutedEventArgs e)
        {
            string login = loginTextBox.Text;
            string password = passwordTextBox.Text;
            if (bAuthorization)
            {
                List<Users> us = new List<Users>();
                await Task.Run(() => us = pp.Users.Where(u => u.login == login).ToList());
                if (us.Count == 0)
                {
                    MaterialDesignThemes.Wpf.HintAssist.SetHelperText(loginTextBox, "Неверный логин");
                    MaterialDesignThemes.Wpf.HintAssist.SetHelperText(passwordTextBox, "");
                    return;
                }
                user = us.First();
                if (user.adopted == false)
                {
                    MaterialDesignThemes.Wpf.HintAssist.SetHelperText(loginTextBox, "Вам ограничен доступ");
                    return;
                }
                if (user.password == password)
                {
                    PageSearch p = new PageSearch();
                    NavigationService.Navigate(p);
                }
                if (user.password != password)
                {
                    MaterialDesignThemes.Wpf.HintAssist.SetHelperText(loginTextBox, "");
                    MaterialDesignThemes.Wpf.HintAssist.SetHelperText(passwordTextBox, "Неверный пароль");
                }
            }
            else
            {
                string repeatPassword = repeatPasswordTextBox.Text;
                int position = positionComboBox.SelectedIndex;
                string lastName = lastNameTextBox.Text;
                string firstName = firstNameTextBox.Text;
                string patronymic = patronymicTextBox.Text;
                bool empty = true;
                TextBox[] textBoxes = { loginTextBox, passwordTextBox, repeatPasswordTextBox, lastNameTextBox, firstNameTextBox, patronymicTextBox };
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
                if (positionComboBox.SelectedIndex == -1)
                {
                    MaterialDesignThemes.Wpf.HintAssist.SetHelperText(positionComboBox, "Поле не выбрано");
                    empty = false;
                }
                else
                    MaterialDesignThemes.Wpf.HintAssist.SetHelperText(positionComboBox, "");

                if (repeatPasswordTextBox.Text != passwordTextBox.Text)
                {
                    MaterialDesignThemes.Wpf.HintAssist.SetHelperText(repeatPasswordTextBox, "Пароли не совпадают");
                    empty = false;
                }

                List<Users> us = new List<Users>();
                await Task.Run(() => us = pp.Users.Where(u => u.login == login).ToList());
                if (us.Count >= 1)
                {
                    MaterialDesignThemes.Wpf.HintAssist.SetHelperText(loginTextBox, "Пользователь с таким логином уже существует");
                    empty = false;
                }

                if (empty)
                {
                    await Task.Run(() =>
                    {
                        Users regUser = new Users();
                        regUser.login = login;
                        regUser.password = password;
                        regUser.position = position + 1;
                        regUser.lastName = lastName;
                        regUser.firstName = firstName;
                        regUser.patronymic = patronymic;
                        pp.Users.Add(regUser);
                        pp.SaveChanges();
                    });
                    foreach (TextBox textBox in textBoxes)
                    {
                        textBox.Text = "";
                        MaterialDesignThemes.Wpf.HintAssist.SetHelperText(textBox, "");
                        empty = false;
                    }
                    positionComboBox.SelectedIndex = -1;
                    btnReg_Click(sender, e);
                }
            }
        }

        private void btnReg_Click(object sender, RoutedEventArgs e)
        {
            if (bAuthorization)
            {
                repeatPasswordTextBox.Visibility = Visibility.Visible;
                positionComboBox.Visibility = Visibility.Visible;
                lastNameTextBox.Visibility = Visibility.Visible;
                firstNameTextBox.Visibility = Visibility.Visible;
                patronymicTextBox.Visibility = Visibility.Visible;
                btnReg.Content = "Войти";
                btnEnter.Content = "Зарегистрироваться";
                bAuthorization = false;
            }
            else
            {
                repeatPasswordTextBox.Visibility = Visibility.Collapsed;
                positionComboBox.Visibility = Visibility.Collapsed;
                lastNameTextBox.Visibility = Visibility.Collapsed;
                firstNameTextBox.Visibility = Visibility.Collapsed;
                patronymicTextBox.Visibility = Visibility.Collapsed;
                btnReg.Content = "Зарегистрироваться";
                btnEnter.Content = "Войти";
                bAuthorization = true;
            }
        }
    }
}
