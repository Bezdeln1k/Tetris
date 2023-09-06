// See https://aka.ms/new-console-template for more information
using System.Reflection.Emit;
using Tetris;
internal class Program
{
    static FigureGenerator generator;
    static void Main(string[] args)
    {        
        Console.SetWindowSize(Field.Width, Field.Height);
        Console.SetBufferSize(Field.Width, Field.Height);

        //Field.Width = 30;

        generator = new FigureGenerator(20, 0, '*');
        Figure currentFigure = generator.GetNewFigure(); 

        while (true)
        {
            if (Console.KeyAvailable)   //"Улавливает" нажатие клавиши в консоли
            {
                //ConsoleKeyInfo key = Console.ReadKey();     //переменная key хранит значение клавиши, которую нажал пользователь
                var key = Console.ReadKey();                  // ключевое слово var "заменяет" любой тип и компилятор сам определяет тип данных
                var result = HandleKey(currentFigure, key.Key);
                ProcessResult(result, ref currentFigure);
            }
        }        
    }
    //Ф-я проверки столкновения фигуры с границей поля или с кучей
    private static bool ProcessResult(Result result, ref Figure currentFigure)
    {
        if (result == Result.HEAP_STRIKE || result == Result.DOWN_BORDER_STRIKE)
        {
            Field.AddFigure(currentFigure);
            currentFigure = generator.GetNewFigure();
            return true;
        }
        else
            return false;
    }

    private static Result HandleKey(Figure f, ConsoleKey key)
    {
        switch (key)
        {
            case ConsoleKey.LeftArrow:
                return f.TryMove(Direction.LEFT);
            case ConsoleKey.RightArrow:
                return f.TryMove(Direction.RIGHT);
            case ConsoleKey.DownArrow:
                return f.TryMove(Direction.DOWN);
            case ConsoleKey.Spacebar:
                return f.TryRotate();
        }
        return Result.SUCCESS;
    }
}