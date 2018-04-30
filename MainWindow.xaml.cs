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
        Ellipse e1 = new Ellipse();
        public MainWindow()
        {
           
            InitializeComponent();
            CreatePlayer();
        }

        private void btnChangeControls_Click(object sender, RoutedEventArgs e)
        {
            ChangeControls ChangeControls = new ChangeControls();
            bool? dialogResult = ChangeControls.ShowDialog();
            if (dialogResult == true)
            {
                MessageBox.Show(ChangeControls.getValue());
            }
        }
        private void PlaySpace_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.W)
            {
                Canvas.SetTop(e1, 100);
            }
        }
        public Ellipse CreatePlayer()
        {
            Ellipse e1 = new Ellipse();
            e1.Height = 20;
            e1.Width = e1.ActualHeight;
            e1.Fill = Brushes.Red;
            Canvas.SetTop(e1, 20);
            Canvas.SetLeft(e1, 20);
            PlaySpace.Children.Add(e1);
            return e1;
        }

        private void TextBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.W)
            {
                MessageBox.Show("ay");
                Canvas.SetTop(e1, 100);
                e1.UpdateLayout();
            }
        }
        /* 
        private void drawRightWall()
        {
            Polygon polygon = new Polygon();
            polygon.Fill = Brushes.Purple;
            polygon.Points.Add(new Point(673, 0));
            polygon.Points.Add(new Point(674, 123));
            polygon.Points.Add(new Point(911, this.Height));
            polygon.Points.Add(new Point(this.Width, this.Height));
            polygon.Points.Add(new Point(this.Width, 0));
            canvas.Children.Add(polygon);
        }*/
    }
}

