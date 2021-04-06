using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;

namespace Shape
{
    class Triangle : Shape
    {
        public List<Point> points { get; set; }

        public override void Draw(Canvas parent, System.Drawing.Point position)
        {
            if (points.Count == 3)
            {
                System.Windows.Shapes.Polygon polygon = new System.Windows.Shapes.Polygon();
                polygon.Points = new PointCollection(points);
                polygon.Stroke = ColorBrush;

                Canvas.SetLeft(polygon, position.X);
                Canvas.SetTop(polygon, position.Y);

                parent.Children.Add(polygon);
            }
            else
            {
                MessageBox.Show("Не верное кол-во точек");
            }
        }
    }
}
