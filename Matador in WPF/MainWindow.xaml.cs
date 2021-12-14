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
using Matador_in_WPF.model;

namespace Matador_in_WPF
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private Player _player = new Player("Jacob", 1, 1000, 0,false);
        
        public MainWindow()
        {
            InitializeComponent();
        }
        
        private void ButtonClick(object sender, RoutedEventArgs e)
        {

            TextId.Text = _player.Name;
        }
    }
}