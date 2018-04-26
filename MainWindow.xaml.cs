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
        public MainWindow()
        {
            InitializeComponent();
        }

        private void btnChangeControls_Click(object sender, RoutedEventArgs e)
        {
            ChangeControls ChangeControls = new ChangeControls();
            bool? dialogResult = ChangeControls.ShowDialog();
            if(dialogResult == true)
            {
                MessageBox.Show(ChangeControls.getValue());
            }
     }

        private void CreatePlayer()
        {
            Ellipse e1 = new Ellipse();
            e1.Height = 20;
            e1.Width = 20;
            e1.Fill = Brushes.Red;
            Canvas.SetTop(e1, 20);
            Canvas.SetLeft(e1, 20);
            PlaySpace.Children.Add(e1);
        }
    }
}

