using Matador_in_WPF.logic.logicInterface;
using Matador_in_WPF.mysql;
using System;
using System.Windows;

namespace Matador_in_WPF.view
{
    public partial class PreGameWindow : Window
    {

        private readonly IScreenSize _screenSize = new ScreenSize();
        private readonly IDBconnection _dBconnection = new DBconnection();
        private string _username, _password;

        public PreGameWindow()
        {
            InitializeComponent();
            _screenSize.SetHeightAndWidthToMax(this);
            _screenSize.CenterWindowOnScreen(this);
            this.Loaded += PreGameWindow_Loaded;
        }

        private void PreGameWindow_Loaded(object sender, RoutedEventArgs e)
        {
            LoginGrid.Visibility = Visibility.Visible;
        }

        //-------------------- Login Grid --------------------------------------------

        private void RegisterButton_OnClick(object sender, RoutedEventArgs e)
        {

            LoginGrid.Visibility = Visibility.Collapsed;
            RegisterGrid.Visibility = Visibility.Visible;
            
        }

        private void LoginButton_OnClick(object sender, RoutedEventArgs e)
        {
            _username = _dBconnection.DbGetUser(TextBoxUsername, "matador.users");
            _password = _dBconnection.DbGetPass(TextBoxUsername, "matador.users");

            if (TextBoxUsername.Text == _username && PasswordBox.Password == _password)
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

        private void ExitButton_OnClick(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();
        }

        // --------------------- Register Grid ----------------------------------------------------------------------

        private void SubmitButton_OnClick(object sender, RoutedEventArgs e)
        {
            _dBconnection.DbRegisterUser(TextBoxFirstName, PasswordBox1, "matador.users");
        }

        private void ResetButton_OnClick(object sender, RoutedEventArgs e)
        {
            TextBoxFirstName.Text = String.Empty;
            PasswordBox1.Password = String.Empty;
            PasswordBoxConfirm.Password = String.Empty;
        }

        private void BackButton_OnClick(object sender, RoutedEventArgs e)
        {
            RegisterGrid.Visibility = Visibility.Collapsed;
            LoginGrid.Visibility = Visibility.Visible;
        }
    }
};

