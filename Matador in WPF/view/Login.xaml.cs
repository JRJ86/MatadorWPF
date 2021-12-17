using System.Windows;
using Matador_in_WPF.logic.logicInterface;

namespace Matador_in_WPF.view
{
    public partial class Login
    {
        
        private readonly IScreenSize _screenSize = new ScreenSize();
        
        public Login()
        {
            InitializeComponent();
            _screenSize.CenterWindowOnScreen(this);
        }

        private void LoginButton_OnClick(object sender, RoutedEventArgs e)
        {
            
        }
    }
}