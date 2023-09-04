// See https://aka.ms/new-console-template for more information
using System.Reflection.Emit;
using Tetris;
internal class Program
{
    private static void Main(string[] args)
    {
        {
            Console.SetWindowSize(Field.WIDTH, Field.HEIGTH);
            Console.SetBufferSize(Field.WIDTH, Field.HEIGTH);

            Field.SetWidth(20);

            FigureGenerator generator = new FigureGenerator(20, 0, '*');
            Figure currentFigure = generator.GetNewFigure(); 

            while (true)
            {
                if (Console.KeyAvailable)   //"Улавливает" нажатие клавиши в консоли
                {
                    //ConsoleKeyInfo key = Console.ReadKey();     //переменная key хранит значение клавиши, которую нажал пользователь
                    var key = Console.ReadKey();                  // ключевое слово var "заменяет" любой тип и компилятор сам определяет тип данных
                    HandleKey(currentFigure, key);
                }
            }

        }

    }

    private static void HandleKey(Figure currentFigure, ConsoleKeyInfo key)
    {
        switch (key.Key)
        {
            case ConsoleKey.LeftArrow:
                currentFigure.TryMove(Direction.LEFT);
                break;
            case ConsoleKey.RightArrow:
                currentFigure.TryMove(Direction.RIGHT);
                break;
            case ConsoleKey.DownArrow:
                currentFigure.TryMove(Direction.DOWN);
                break;
            case ConsoleKey.Spacebar:
                currentFigure.TryRotate();
                break;
        }
    }
}