using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tetris
{
    internal class Figure
    {
        protected Point[] points = new Point[4]; //protected означает, что точки(points) можно использовать только в дочерних классах
        public void Draw()
        {
            foreach (Point l in points)
            {
                l.Draw();
            }
        }
    }
}
