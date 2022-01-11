using System.Windows;
using Matador_in_WPF.logic.logicInterface;

namespace Matador_in_WPF.view
{
    public partial class StartupWindow : Window
    {
        private readonly IScreenSize _screenSize = new ScreenSize();
        
        public StartupWindow()
        {
            InitializeComponent();
            _screenSize.CenterWindowOnScreen(this);
        }
    
        private void StartupButton_OnClick(object sender, RoutedEventArgs e)
        {
            var login = new LoginWindow();
            login.Show();
            Close();
        }
    }
};

