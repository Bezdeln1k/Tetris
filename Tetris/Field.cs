using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tetris
{
    static class Field      //статичный класс, чтобы нельзя было создать экземпляры класса в другом месте программы
    {
        public const int WIDTH = 40;    // переменные заданы в виде констант, чтобы нельзя было переопределить в другом месте программы
        public const int HEIGTH = 30;
    }
}
