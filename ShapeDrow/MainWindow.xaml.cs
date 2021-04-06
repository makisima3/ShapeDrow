using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;

namespace ShapeDrow
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private Brush brush = Brushes.Black;

        public MainWindow()
        {
            InitializeComponent();
        }

        private void Rect_Checked(object sender, RoutedEventArgs e)
        {
            RectGrid.Visibility = Visibility.Visible;
            RectGrid.IsEnabled = true;

            TriGrid.Visibility = Visibility.Hidden;
            TriGrid.IsEnabled = false;
        }

        private void tri_Checked(object sender, RoutedEventArgs e)
        {
            RectGrid.Visibility = Visibility.Hidden;
            RectGrid.IsEnabled = false;

            TriGrid.Visibility = Visibility.Visible;
            TriGrid.IsEnabled = true;
        }

        private void Black_Checked(object sender, RoutedEventArgs e)
        {
            brush = Brushes.Black;
        }

        private void Green_Checked(object sender, RoutedEventArgs e)
        {
            brush = Brushes.Green;
        }


        private void NumberValidationTextBox(object sender, TextCompositionEventArgs e)
        {
            Regex regex = new Regex("[^0-9]+");
            e.Handled = regex.IsMatch(e.Text);
        }

        private void Drow_Click(object sender, RoutedEventArgs e)
        {
            if(Rect.IsChecked == true)
            {
                Shape.Ellipse ellipse = new Shape.Ellipse();
                ellipse.Height = Convert.ToInt32(InputHeight.Text);
                ellipse.Width = Convert.ToInt32(InputWidth.Text);
                ellipse.ColorBrush = brush;

                ellipse.Draw(DrawFiled,new System.Drawing.Point(20,20));
            }
            if(tri.IsChecked == true)
            {
                //Это не относится к показу знаний ООП так что я решил не парится с инициализацией
                List<Point> points = new List<Point>();
                points.Add(new Point(Convert.ToInt32(InputPoint1X.Text), Convert.ToInt32(InputPoint1Y.Text)));
                points.Add(new Point(Convert.ToInt32(InputPoint2X.Text), Convert.ToInt32(InputPoint2Y.Text)));
                points.Add(new Point(Convert.ToInt32(InputPoint3X.Text), Convert.ToInt32(InputPoint3Y.Text)));

                Shape.Triangle triangle = new Shape.Triangle();
                triangle.points = points;
                triangle.ColorBrush = brush;

                triangle.Draw(DrawFiled, new System.Drawing.Point(20, 20));
            }
        }
    }
}
