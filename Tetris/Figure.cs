using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tetris
{
    abstract class Figure
    {
        const int LENGTH = 4;
        protected Point[] points = new Point[LENGTH]; //protected означает, что точки(points) можно использовать только в дочерних классах
        
        public void Draw()                  //Метод Draw - рисует на экране элемент который описан заданными свойствами
        {
            foreach (Point p in points)
            {
                p.Draw();
            }
        }

        public void Hide()
        {
            foreach (Point p in points)
            {
                p.Hide();
            }
        }

        public abstract void Rotate(Point[] pList);

        //public void Move(Direction dir)     //Move - перемещает (в данном случае фигуру) в новое место
        //{
        //    Hide();
        //    foreach(Point p in points)
        //    {
        //        p.Move(dir);
        //    }
        //    Draw();
        //}

        private bool VerifyPosition(Point[] pList)      //ф-я проверки границ окна
        {
            foreach(var p in pList)
            {
                if(p.X < 0 || p.Y < 0 || p.X >= Field.Width || p.Y >= Field.Height)
                    return false;
            }
            return true;
        }

        public void Move(Point[] pList, Direction dir)
        {
            foreach (var p in pList)
            {
                p.Move(dir);
            }
        }

        internal void TryMove(Direction dir)
        {
            Hide();
            var clone = Clone();    //явного указания типа Point[]
            Move(clone, dir);

            if (VerifyPosition(clone))
                points = clone;

            Draw();
        }

        private Point[] Clone()     //копия массива 
        {
            var newPoints = new Point[LENGTH];
            for(int i = 0; i < LENGTH; i++)
            {
                newPoints[i] = new Point(points[i]);
            }
            return newPoints;
        }

        internal void TryRotate()
        {
            Hide();
            var clone = Clone();    //явного указания типа Point[]
            Rotate(clone);

            if (VerifyPosition(clone))
                points = clone;

            Draw();
        }
    }
}
