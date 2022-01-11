using System;
using System.Windows;
using Matador_in_WPF.logic.logicInterface;
using MySql.Data.MySqlClient;

namespace Matador_in_WPF.view
{
    public partial class RegisterWindow : Window
    {

        private readonly IScreenSize _screenSize = new ScreenSize();
        
        public RegisterWindow()
        {
            InitializeComponent();
            _screenSize.CenterWindowOnScreen(this);
            
        }

        private void SubmitButton_OnClick(object sender, RoutedEventArgs e)
        {
            try
            {
                const string myConnection = "datasource=localhost;port=3306;username=root;password=password";
                var query = "INSERT INTO matador.users (username,pass) VALUES ('" + this.TextBoxFirstName.Text + "','" +
                             this.PasswordBox1.Password + "' );";
                MySqlConnection mySqlConnection = new MySqlConnection(myConnection);
                MySqlCommand mySqlCommand = new MySqlCommand(query, mySqlConnection);
                MySqlDataReader dataReader;
                mySqlConnection.Open();
                dataReader = mySqlCommand.ExecuteReader();
                MessageBox.Show("Save data!");
                while (dataReader.Read()) {}
                mySqlConnection.Close();
                
            }
            catch (Exception exception)
            {
                Console.WriteLine(exception);
                MessageBox.Show(exception.Message);
                throw;
            }
            
            
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

