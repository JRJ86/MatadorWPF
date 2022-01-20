using System.Windows;
using System.Windows.Controls;
using Matador_in_WPF.logic.logicInterface;
using Matador_in_WPF.mysql;

namespace Matador_in_WPF.view.UserControl
{
    public partial class LoginUc : System.Windows.Controls.UserControl
    {
        
        private readonly IDBconnection _dBconnection = new DBconnection();
        private string _username, _password;
        
        public LoginUc()
        {
            InitializeComponent();
        }

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
            System.Windows.Controls.UserControl registerUserControl = new RegisterUc();
        }

        private void ExitButton_OnClick(object sender, RoutedEventArgs e)
        {
            System.Windows.Application.Current.Shutdown();
        }
    }
};

