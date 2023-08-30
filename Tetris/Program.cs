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
            Figure s = null;

            while (true)
            {
                FigureFall(s, generator);
                s.Draw();
            }




            //s.Draw();                       // Отрисовали фигуру

            //Thread.Sleep(500);             // Вставили задержку на 0.5 сек, чтобы увидеть движение фигуры в консоли

            //s.Hide();                       // Скрыли фигуру
            //s.Rotate();                     // Потом повернули фигуру
            //s.Draw();                       // И снова отрисовали



            //Thread.Sleep(500);             // Вставили задержку на 0.5 сек, чтобы увидеть движение фигуры в консоли

            //s.Hide();                       // Скрыли фигуру
            //s.Move(Direction.LEFT);         // Потом сдвинули его налево
            //s.Draw();                       // И снова отрисовали


            //Figure[] f = new Figure[2];
            //f[0] = new Square(2, 5, '*');
            //f[1] = new Stick(10, 10, '*');

            //foreach (Figure fig in f)
            //{
            //    fig.Draw();
            //}


            //рисую палку сам
            //Stick l = new Stick(10, 10, '*');
            //l.Draw();

            //Square s = new Square(2, 5, '*');   //рисование квадрата из "*", используя конструктор в классе Square
            //s.Draw();

            //Point p1 = new Point(2, 3, '*');  //вывод произвольных точек x,y из символа "*"
            //p1.Draw();

            //Point p2 = new Point()
            //{
            //    x = 4,
            //    y = 5,
            //    c = '#'
            //};
            //p2.Draw();



            //Console.ReadLine();
        }
        static void FigureFall(Figure fig, FigureGenerator generator)
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