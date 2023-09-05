using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tetris
{
    //статичный класс, чтобы нельзя было создать экземпляры класса в другом месте программы
    static class Field      
    {
        private static int _width = 40;
        private static int _height = 30;

        //св-во,которое задает ширину, с которым можно работать как с обычной переменной
        public static int Width     
        {
            get
            {
                return _width;
            }
            set
            {
                _width = value;
                Console.SetWindowSize(_width, Field.Height);
                Console.SetBufferSize(_width, Field.Height);
            }
        }

        //св-во,которое задает ширину, с которым можно работать как с обычной переменной
        public static int Height     
        {
            get
            {
                return _height;
            }
            set
            {
                _height = value;
                Console.SetWindowSize(value, Field.Height);
                Console.SetBufferSize(value, Field.Height);
            }
        }

        private static bool[][] _heap;

        static Field()
        {
            _heap = new bool[Height][];
            for(int i = 0; i < Height; i++)
            {
                _heap[i] = new bool[Width];
            }
        }

        public static bool CheckStrike(Point p)
        {
            return _heap[p.Y][p.X];
        }
        public static void AddFigure(Figure fig)
        {
            foreach(var p in fig.Points)
            {
                _heap[p.Y][p.X] = true;
            }
        }


        //Ф-я, которая будет вызываться для смены ширины экрана (пример программы без использования геттеров и сеттеров)
        //public static int GetWidth()        
        //{
        //    return _width;
        //}
        //public static void SetWidth(int value)
        //{
        //    _width = value;
        //    Console.SetWindowSize(_width, Field.HEIGTH);
        //    Console.SetBufferSize(_width, Field.HEIGTH);
        //}
    }
}
