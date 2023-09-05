using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tetris
{
    static class Field      //статичный класс, чтобы нельзя было создать экземпляры класса в другом месте программы
    {
        private static int _width = 40;
        private static int _height = 30;
       
        public static int Width     //св-во,которое задает ширину, с которым можно работать как с обычной переменной
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
        
        public static int Height     //св-во,которое задает ширину, с которым можно работать как с обычной переменной
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

        


        //public static int GetWidth()        //Ф-я, которая будет вызываться для смены ширины экрана (пример программы без использования геттеров и сеттеров)
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
