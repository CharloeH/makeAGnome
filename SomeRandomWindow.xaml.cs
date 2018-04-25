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
using System.Windows.Shapes;

namespace makeAGnome
{
    /// <summary>
    /// Interaction logic for SomeRandomWindow.xaml
    /// </summary>
    public partial class SomeRandomWindow : Window
    {
        public SomeRandomWindow()
        {
            InitializeComponent();
        }

        private void btnReturn_Click(object sender, RoutedEventArgs e)
        {
            this.DialogResult = true;
        }

        public string getValue()
        {
            return txtShareThis.Text;
        }

        private void btnCancel_Click(object sender, RoutedEventArgs e)
        {
            this.DialogResult = false;
        }
    }
}
