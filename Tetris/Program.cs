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
            Figure? s; // знак ? говорит компилятору, что допускается значение null. 

            while (true)
            {
                FigureFall(out s, generator); // s - ссылка на область опер.памяти. Чтобы ссылка поменялась (и после выполнения ф-и FigureFall
                                              // переменная s приняла значение переменной fig) нужно ставить ключевое слово ref; либо out - если
                                              // разработчик уверен, что переменная с ключевым словом out будет задана
                s.Draw();
            }

        }
        static void FigureFall(out Figure fig, FigureGenerator generator)
        {
            fig = generator.GetNewFigure();
            fig.Draw();

            for (int i = 0; i < 15; i++)
            {
                fig.Hide();
                fig.Move(Direction.DOWN);
                fig.Draw();
                Thread.Sleep(200);
            }
        }

    }

    
}