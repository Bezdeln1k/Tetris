// See https://aka.ms/new-console-template for more information
using System.Reflection.Emit;
using Tetris;
internal class Program
{
    private static void Main(string[] args)
    {
        {
            Console.SetWindowSize(40, 30);
            Console.SetBufferSize(40, 30);

            FigureGenerator generator = new FigureGenerator(20, 0, '*');
            Figure currentFigure = generator.GetNewFigure(); 

            while (true)
            {
                if (Console.KeyAvailable)   //"Улавливает" нажатие клавиши в консоли
                {
                    //ConsoleKeyInfo key = Console.ReadKey();     //переменная key хранит значение, которое нажал пользователь
                    var key = Console.ReadKey();                  // ключевое слово var "заменяет" любой тип и компилятор сам определяет тип данных

                }
            }

        }

    }

    
}