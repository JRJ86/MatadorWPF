using System.Windows;
using Matador_in_WPF.logic.logicInterface;

namespace Matador_in_WPF.view
{
    public partial class Startup
    {
        private readonly IScreenSize _screenSize = new ScreenSize();
        
        public Startup()
        {
            InitializeComponent();
            _screenSize.CenterWindowOnScreen(this);
        }
    
        private void StartupButton_OnClick(object sender, RoutedEventArgs e)
        {
            var login = new Login();
            login.Show();
            Close();
        }
    }
};

