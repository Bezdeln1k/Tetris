using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tetris
{
    class Stick : Figure
    {
        public Stick(int x, int y, char sym)          //мой вариант реализации "палки" (оказалось правильно :D)
        {
            points[0] = new Point(x, y, sym);
            points[1] = new Point(x, y + 1, sym);
            points[2] = new Point(x, y + 2, sym);
            points[3] = new Point(x, y + 3, sym);
            Draw();
        }

        public override void Rotate()
        {
            if (points[0].x == points[1].x) //если значение х не отличается, т.е. в данном случае фигура вертикальна
            {
                RotateHorizontal();
            }
            else
            {
                RotateVertical();
            }
        }

        private void RotateHorizontal()
        {
            for(int i = 0; i < points.Length; i++)
            {
                points[i].y = points[0].y;
                points[i].x = points[0].x + i;

            }
        }
        private void RotateVertical()
        {
            for (int i = 0; i < points.Length; i++)
            {
                points[i].x = points[0].x;
                points[i].y = points[0].y + i;

            }
        }
    }
}
