using System;
using System.Windows;
using Matador_in_WPF.logic.logicInterface;
using Matador_in_WPF.view.UserControl;

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
            this.Loaded += MainWindow_Loaded;
        }

        private void MainWindow_Loaded(object sender, RoutedEventArgs e)
        {
            System.Windows.Controls.UserControl loginUserControl = new LoginUc();
            StackPanel.Children.Add(loginUserControl);
        }
    }
};

