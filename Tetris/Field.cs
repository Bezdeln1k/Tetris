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
        public const int HEIGTH = 30;


        public static int GetWidth()        //Ф-я, которая будет вызываться для смены ширины экрана (пример программы без использования геттеров и сеттеров)
        {
            return _width;
        }
        public static void SetWidth(int value)
        {
            _width = value;
            Console.SetWindowSize(_width, Field.HEIGTH);
            Console.SetBufferSize(_width, Field.HEIGTH);
        }
    }
}
