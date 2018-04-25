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
    /// Interaction logic for ChangeControls.xaml
    /// </summary>
    public partial class ChangeControls : Window
    {
        string[] Controls = new string[10];
        public ChangeControls()
        {
            InitializeComponent();
            /*var win2 = MainWindow(Key[]);
            win2.Show();
            this.Close();*/

            ChangeButtons(Controls);
        }

        private void ChangeButtons(string[] Controls)
        {
            Controls[1] = txtChangeForward.Text;//forward
            Controls[2] = txtChangeBackward.Text;//backward
            Controls[3] = txtChangeLeft.Text;//left
            Controls[4] = txtChangeRight.Text;//right
            Controls[5] = txtChangeShoot.Text;//shoot
        }

        private void btnChange_Click(object sender, RoutedEventArgs e)
        {
            SomeRandomWindow someRandomWindow = new SomeRandomWindow();
            bool? dialogResult = someRandomWindow.ShowDialog();
            if (dialogResult == true)
            {
                MessageBox.Show(someRandomWindow.getValue());
            }
            ChangeButtons(Controls);
        }
    }
}
