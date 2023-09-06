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
        public Point[] Points = new Point[LENGTH]; //protected означает, что точки(points) можно использовать только в дочерних классах
        
        public void Draw()                  //Метод Draw - рисует на экране элемент который описан заданными свойствами
        {
            foreach (Point p in Points)
            {
                p.Draw();
            }
        }

        public void Hide()
        {
            foreach (Point p in Points)
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

        //private bool VerifyPosition(Point[] pList)      //ф-я проверки границ окна
        //{
        //    foreach(var p in pList)
        //    {
        //        if(p.X < 0 || p.Y < 0 || p.X >= Field.Width || p.Y >= Field.Height)
        //            return false;
        //    }
        //    return true;
        //}
        
        private Result VerifyPosition(Point[] newPoints)
        {
            foreach(var p in newPoints)
            {
                if (p.Y >= Field.Height)
                    return Result.DOWN_BORDER_STRIKE;   //нижняя граница
                
                if (p.X >= Field.Width || p.X < 0 || p.Y < 0)
                    return Result.BORDER_STRIKE;    //боковая граница

                if (Field.CheckStrike(p))
                    return Result.HEAP_STRIKE;      //столкновение с кучей фигур
            }
            return Result.SUCCESS;
        }

        public void Move(Point[] pList, Direction dir)
        {
            foreach (var p in pList)
            {
                p.Move(dir);
            }
        }

        internal Result TryMove(Direction dir)
        {
            Hide();
            var clone = Clone();    //явного указания типа Point[]
            Move(clone, dir);

            var result = VerifyPosition(clone);
            if (result == Result.SUCCESS)
                Points = clone;

            Draw();
            return result;
        }

        private Point[] Clone()     //копия массива 
        {
            var newPoints = new Point[LENGTH];
            for(int i = 0; i < LENGTH; i++)
            {
                newPoints[i] = new Point(Points[i]);
            }
            return newPoints;
        }

        internal Result TryRotate()
        {
            Hide();
            var clone = Clone();    //явного указания типа Point[]
            Rotate(clone);

            var result = VerifyPosition(clone);
            if (result == Result.SUCCESS)
                Points = clone;

            Draw();
            return result;
        }
    }
}
