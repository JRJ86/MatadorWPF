using System;
using System.Windows;
using System.Windows.Controls;
using Matador_in_WPF.logic.logicInterface;
using Matador_in_WPF.model.chanceCards;
using Matador_in_WPF.mysql;

namespace Matador_in_WPF.view
{
    public partial class LoginWindow : Window
    {

        private readonly IScreenSize _screenSize = new ScreenSize();
        private readonly IDBconnection _dBconnection = new DBconnection();
        private string _username, _password;

        public LoginWindow()
        {
            InitializeComponent();
            _screenSize.CenterWindowOnScreen(this);
        }

        /**
         * Change this to make it fetch data from a database TODO!!
         */
        private void LoginButton_OnClick(object sender, RoutedEventArgs e)
        {
            _username = _dBconnection.DbGetUser(TextBoxUsername,"matador.users");
            _password = _dBconnection.DbGetPass(TextBoxUsername,"matador.users");
            
            if (TextBoxUsername.Text == _username  && PasswordBox.Password == _password)
            {
                MessageBox.Show("Hooray!!");
            }
            else if (string.IsNullOrEmpty(TextBoxUsername.Text))
            {
                MessageBox.Show("Enter your username!", "Empty field!", MessageBoxButton.OK, MessageBoxImage.Information);
                TextBoxUsername.Focus();
            }
            else if (string.IsNullOrEmpty(PasswordBox.Password))
            {
                MessageBox.Show("Enter your password!", "Empty field!", MessageBoxButton.OK, MessageBoxImage.Information);
                PasswordBox.Focus();
            }
            else
            {
                MessageBox.Show("Wrong username or password!", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
            }

        }

        private void RegisterButton_OnClick(object sender, RoutedEventArgs e)
        {

            //var result = MessageBox.Show("You are being directed to the register page!", "Info", MessageBoxButton.YesNo,
            //    MessageBoxImage.Question);

            //if (result != MessageBoxResult.Yes) return;
            var registration = new RegisterWindow();
            registration.Show();
            Close();

        }


        private void ExitButton_OnClick(object sender, RoutedEventArgs e)
        {
            throw new NotImplementedException();
        }
    }
}