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

namespace UWUVCI_MEDIA.UI.Frames
{
    /// <summary>
    /// Interaktionslogik für Page1.xaml
    /// </summary>
    public partial class MainFrame : Page
    {
        public MainFrame()
        {
            InitializeComponent();
            tb.Text += "\n\n Use this tool to play Movies/Videos or Audio on your WiiU.";
        }
    }
}
