using System;
using System.Windows;
using System.Windows.Controls;
using MySQL.Data;
using MySql.Data.MySqlClient;

namespace Matador_in_WPF.mysql
{
    public class DBconnection : IDBconnection
    {
        private const string MyConnection = "datasource=localhost;port=3306;username=root;password=password";
        //private MySqlConnection mySqlConnection;
        //private MySqlCommand mySqlCommand;
        //private MySqlDataReader mySqlDataReader;

        public void DbRegisterUser(TextBox textBox, PasswordBox passwordBox, string tableName)
        {
            if (Exist(tableName,"username",textBox))
            {
                MessageBox.Show("Username already exists. Pick another!", "Username invalid!", MessageBoxButton.OK,
                    MessageBoxImage.Information);
            }
            else
            {
                try
                {
                    var query = "INSERT INTO " + tableName + " (username,pass) VALUES(@username,@pass);";
                    using MySqlConnection mySqlConnection = new MySqlConnection(MyConnection);
                    mySqlConnection.Open();
                    
                    using MySqlCommand mySqlCommand = new MySqlCommand(query,mySqlConnection);
                    mySqlCommand.Parameters.Add("@username", MySqlDbType.VarChar);
                    mySqlCommand.Parameters.Add("@pass", MySqlDbType.VarChar);
                    mySqlCommand.Parameters["@username"].Value = textBox.Text;
                    mySqlCommand.Parameters["@pass"].Value = passwordBox.Password;
                    
                    using MySqlDataReader mySqlDataReader = mySqlCommand.ExecuteReader();
                    while (mySqlDataReader.Read()){}
                    MessageBox.Show("User successfully created!", "User created!", MessageBoxButton.OK,
                        MessageBoxImage.Information);
                    
                    mySqlDataReader.Close();
                    mySqlConnection.Close();
                    
                }
                catch (Exception exception)
                {
                    MessageBox.Show(exception.Message,"From DbRegisterUser method!",MessageBoxButton.OK,MessageBoxImage.Error);
                    throw;
                }
            }
        }

        public string DbGetUser(TextBox textBox, string tableName)
        {
            string username = null;
            if (!Exist("matador.users","username",textBox))
            {
                MessageBox.Show("Username does not exist. Try another!", "Invalid username!", MessageBoxButton.OK,
                    MessageBoxImage.Warning);
            }
            else
            {
                try
                {
                    var query = "SELECT username FROM " + tableName + " WHERE username=@username;";
                    using MySqlConnection mySqlConnection = new MySqlConnection(MyConnection);
                    mySqlConnection.Open();
                    
                    using MySqlCommand mySqlCommand = new MySqlCommand(query,mySqlConnection);
                    mySqlCommand.Parameters.Add("@username", MySqlDbType.VarChar);
                    mySqlCommand.Parameters["@username"].Value = textBox.Text;
                    
                    //using MySqlDataReader mySqlDataReader = mySqlCommand.ExecuteReader();
                    var queryResult = mySqlCommand.ExecuteScalar();
                    if (queryResult != null)
                    {
                        username = Convert.ToString(queryResult);
                    }
                    //while (mySqlDataReader.Read())
                    //{
                    //    username = mySqlDataReader.GetString(0);
                    //}
                    //mySqlDataReader.Close();
                    mySqlConnection.Close();
                    
                    return username;
                }
                catch (Exception exception)
                {
                    MessageBox.Show(exception.Message, "From DbGetUser method!", MessageBoxButton.OK, MessageBoxImage.Error);
                    throw;
                }
            }
            return null;
        }

        public string DbGetPass(TextBox textBox, string tableName)
        {
            string password = null;
            if (!Exist("matador.users","username",textBox))
            {
                MessageBox.Show("Username does not exist. Try another!", "Invalid username!", MessageBoxButton.OK,
                    MessageBoxImage.Warning);
            }
            else
            {
                try
                {
                    var query = "SELECT pass FROM " + tableName + " WHERE username=@username;";
                    using MySqlConnection mySqlConnection = new MySqlConnection(MyConnection);
                    mySqlConnection.Open();
                    
                    using MySqlCommand mySqlCommand = new MySqlCommand(query,mySqlConnection);
                    mySqlCommand.Parameters.Add("@username", MySqlDbType.VarChar);
                    mySqlCommand.Parameters["@username"].Value = textBox.Text;
                    
                    //using MySqlDataReader mySqlDataReader = mySqlCommand.ExecuteReader();
                    var queryResult = mySqlCommand.ExecuteScalar();
                    if (queryResult != null)
                    {
                        password = Convert.ToString(queryResult);
                    }
                    
                    //while (mySqlDataReader.Read())
                    //{
                      //  password = mySqlDataReader.GetString(0);
                    //}
                    //mySqlDataReader.Close();
                    mySqlConnection.Close();

                    return password;

                }
                catch (Exception exception)
                {
                    MessageBox.Show(exception.Message, "From DbGetPass method!", MessageBoxButton.OK, MessageBoxImage.Error);
                    throw;
                }
            }
            return null;
        }

        private bool Exist(string tableName, string columnName, TextBox textBox)
        {
            long count;
            try
            {
                var query = "SELECT count(*) FROM " + tableName + " WHERE " + columnName + "='" + textBox.Text + "'";
                using MySqlConnection mySqlConnection = new MySqlConnection(MyConnection);
                mySqlConnection.Open();
                using MySqlCommand mySqlCommand = new MySqlCommand(query, mySqlConnection);
                using MySqlDataReader mySqlDataReader = mySqlCommand.ExecuteReader();
                while (mySqlDataReader.Read()){}

                mySqlDataReader.Close();
                count = (long) mySqlCommand.ExecuteScalar();
                mySqlConnection.Close();
               
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message, "From Exists method!", MessageBoxButton.OK, MessageBoxImage.Error);
                throw;
            }
            return count != 0;
        }
    }
};

