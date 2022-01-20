using System.Windows;
using Matador_in_WPF.logic.logicInterface;

namespace Matador_in_WPF.view
{
    public partial class GameScreenWindow : Window
    {
        private readonly IScreenSize _screenSize = new ScreenSize();
        public GameScreenWindow()
        {
            InitializeComponent();
            _screenSize.SetHeightAndWidthToMax(this);
        }
    }
};

