using System;
using System.Windows;
using Matador_in_WPF.logic.logicInterface;

namespace Matador_in_WPF.view
{
    public partial class PickGameWindow : Window
    {
        private readonly IScreenSize _screenSize = new ScreenSize();
        
        public PickGameWindow()
        {
            InitializeComponent();
            _screenSize.SetHeightAndWidthToMax(this);
            _screenSize.CenterWindowOnScreen(this);
        }

    }
};

