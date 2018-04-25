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

namespace makeAGnome
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public static char keyForward = 'w';
        public static char keyBackward = 's';
        public static char keyLeft = 'a';
        public static char keyRight = 'd';
        public MainWindow()
        {
            InitializeComponent();
        }

        private void btnStart_Click(object sender, RoutedEventArgs e)
        {

        }

        private void btnStart_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.W)
            {

            }
            if (e.Key == Key.S)
            {

            }
            if(e.Key == Key.A)
            {

            }
            if(e.Key == Key.D)
            {

            }
        }
    }
}
