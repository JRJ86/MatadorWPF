using System.Windows;
using Matador_in_WPF.logic.logicInterface;
using Matador_in_WPF.model.chanceCards;

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

        private void RegisterButton_OnClick(object sender, RoutedEventArgs e)
        {
            throw new System.NotImplementedException();
        }
    }
}