using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tetris
{
    abstract class Figure
    {
        protected Point[] points = new Point[4]; //protected означает, что точки(points) можно использовать только в дочерних классах
        
        public void Draw()                  //Метод Draw - рисует на экране элемент который описан заданными свойствами
        {
            foreach (Point p in points)
            {
                p.Draw();
            }
        }

        public void Move(Direction dir)     //Move - перемещает (в данном случае фигуру) в новое место
        {
            Hide();
            foreach(Point p in points)
            {
                p.Move(dir);
            }
            Draw();
        }

        public void Hide()
        {
            foreach (Point p in points)
            {
                p.Hide();
            }
        }

        public abstract void Rotate();
    }
}
