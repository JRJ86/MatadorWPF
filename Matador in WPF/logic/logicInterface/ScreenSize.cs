using System.Windows;

namespace Matador_in_WPF.logic.logicInterface
{
    /*
     * This method is for setting a window at the center of a computer monitor
     *
     *
     * You could also set the XAML definition for the window to:
     *              WindowStartupLocation="CenterScreen"
     */ 
    public class ScreenSize : IScreenSize
    {
        public void CenterWindowOnScreen(Window window)
        {
            var screenWidth = System.Windows.SystemParameters.PrimaryScreenWidth;
            var screenHeight = System.Windows.SystemParameters.PrimaryScreenHeight;
            var windowWidth = window.Width;
            var windowHeight = window.Height;
            window.Left = (screenWidth / 2) - (windowWidth / 2);
            window.Top = (screenHeight / 2) - (windowHeight / 2);
        }
    }
};

