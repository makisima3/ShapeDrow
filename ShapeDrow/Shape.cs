using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Media;
namespace Shape
{
    public abstract class Shape
    {
        public string Name { get; set; }

        public Brush ColorBrush { get; set; }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="parent">The parent whose child the item will be</param>
        public abstract void Draw(Canvas parent,Point position);
    }
}
