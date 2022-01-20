using System;
using System.Windows;
using Matador_in_WPF.logic.logicInterface;

namespace Matador_in_WPF.view
{
    public partial class MainWindow : Window
    {
        private readonly IScreenSize _screenSize = new ScreenSize();
        
        public MainWindow()
        {
            InitializeComponent();
            _screenSize.SetHeightAndWidthToMax(this);
            _screenSize.CenterWindowOnScreen(this);
        }

        private void StartupButton_OnClick(object sender, RoutedEventArgs e)
        {
            var preGameWindow = new PreGameWindow();
            preGameWindow.Show();
            Close();
        }
    }
};

