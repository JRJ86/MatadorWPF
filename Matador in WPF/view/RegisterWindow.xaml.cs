using System;
using System.Windows;
using Matador_in_WPF.logic.logicInterface;
using Matador_in_WPF.mysql;
using MySql.Data.MySqlClient;

namespace Matador_in_WPF.view
{
    public partial class RegisterWindow : Window
    {

        private readonly IScreenSize _screenSize = new ScreenSize();
        private readonly IDBconnection _dBconnection = new DBconnection();
        
        public RegisterWindow()
        {
            InitializeComponent();
            _screenSize.CenterWindowOnScreen(this);
            
        }

        private void SubmitButton_OnClick(object sender, RoutedEventArgs e)
        {
            _dBconnection.DbRegisterUser(TextBoxFirstName,PasswordBox1,"matador.users");
        }

        private void ResetButton_OnClick(object sender, RoutedEventArgs e)
        {
            TextBoxFirstName.Text = String.Empty;
            PasswordBox1.Password = String.Empty;
            PasswordBoxConfirm.Password = String.Empty;
        }

        private void BackButton_OnClick(object sender, RoutedEventArgs e)
        {
            throw new System.NotImplementedException();
        }
    }
};

