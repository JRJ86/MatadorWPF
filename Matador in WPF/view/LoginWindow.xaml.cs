using System;
using System.Windows;
using System.Windows.Controls;
using Matador_in_WPF.logic.logicInterface;
using Matador_in_WPF.model.chanceCards;

namespace Matador_in_WPF.view
{
    public partial class LoginWindow : Window
    {
        private TextBlock _headline, _usernameText, _passwordText;
        private TextBox _textBoxEmail;
        private PasswordBox _passwordBox;
        private Button _loginButton, _registerButton;

        private readonly IScreenSize _screenSize = new ScreenSize();

        public LoginWindow()
        {
            InitializeComponent();
            _screenSize.CenterWindowOnScreen(this);
            
            // make an If statement to see what state the window has
            // ------------------------Content of Window----------------------

        }

        /**
         * Change this to make it fetch data from a database TODO!!
         */
        private void LoginButton_OnClick(object sender, RoutedEventArgs e)
        {
            if (TextBoxEmail.Text == "jrj@email.com" && PasswordBox.Password == "pass")
            {
                // Go on to the game!
            }
            else if (string.IsNullOrEmpty(TextBoxEmail.Text))
            {
                MessageBox.Show("Enter your username!", "Empty field!", MessageBoxButton.OK, MessageBoxImage.Information);
                TextBoxEmail.Focus();
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

            var result = MessageBox.Show("You are being directed to the register page!", "Info", MessageBoxButton.YesNo,
                MessageBoxImage.Question);

            if (result != MessageBoxResult.Yes) return;
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