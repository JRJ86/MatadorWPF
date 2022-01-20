using System.Windows.Controls;

namespace Matador_in_WPF.mysql
{
    public interface IDBconnection
    {
        void DbRegisterUser(TextBox textBox, PasswordBox passwordBox, string tableName);
        string DbGetUser(TextBox textBox, string tableName);
        string DbGetPass(TextBox textBox, string tableName);
    }
};

