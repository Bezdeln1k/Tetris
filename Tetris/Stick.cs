using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tetris
{
    public class Stick
    {
        Point[] points = new Point[4];

        public Stick(int x, int y, char sym)          //мой вариант реализации "палки" (оказалось правильно :D)
        {
            points[0] = new Point(x, y, sym);
            points[1] = new Point(x, y + 1, sym);
            points[2] = new Point(x, y + 2, sym);
            points[3] = new Point(x, y + 3, sym);
        }

        public void Draw()
        {
            foreach (Point l in points)
            {
                l.Draw();
            }
        }
    }
}
