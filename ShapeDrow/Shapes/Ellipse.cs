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
    class Ellipse : Shape
    {
        public double Width { get; set; }

        public double Height { get; set; }

        public override void Draw(Canvas parent,System.Drawing.Point position)
        {
            System.Windows.Shapes.Ellipse ellipse = new System.Windows.Shapes.Ellipse();
            ellipse.Width = Width;
            ellipse.Height = Height;
            ellipse.Stroke = ColorBrush;
            ellipse.Name = Name;

            Canvas.SetLeft(ellipse, position.X);
            Canvas.SetTop(ellipse, position.Y);

            parent.Children.Add(ellipse);
        }
    }
}
