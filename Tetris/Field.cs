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

        //2-мерный массив, хранит инф-ю, что в данном массиве есть или нет фигуры
        private static bool[][] _heap;

        static Field()
        {
            //инициализируем массив и говорим, что кол-во строк в 2-мерном массиве
            //соотвествует высоте игрового поля (Куча из фигур на дне игрового поля)
            _heap = new bool[Height][];
            for(int i = 0; i < Height; i++)
            {
                _heap[i] = new bool[Width];
            }
        }
        //ф-я отслеживает столкновение фигуры с упавшими фигурами (кучей)
        public static bool CheckStrike(Point p)
        {
            //возвращаем текущее значение массива (кучи фигур на дне).
            //Если по текущей координате X и Y что-то лежит (есть значение true),
            //то значит, что столкновение есть
            return _heap[p.Y][p.X];
        }
        //ф-я добавляет новые фигуры на кучу фигур на дне игрового поля
        public static void AddFigure(Figure fig)
        {
            //пробежим по всем точках внутри фигуры
            foreach(var p in fig.Points)
            {
                //отметим в массиве занятые ячейки значением true
                //на кучу добавилась новая фигура и эти точки отмечены true
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
