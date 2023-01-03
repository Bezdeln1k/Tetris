// See https://aka.ms/new-console-template for more information
using Tetris;
internal class Program
{
    private static void Main(string[] args)
    {
        {
            Console.SetWindowSize(40, 30);
            Console.SetBufferSize(40, 30);

            Figure[] f = new Figure[2];
            f[0] = new Square(2, 5, '*');
            f[1] = new Stick(10, 10, '*');

            foreach (Figure fig in f)
            {
                fig.Draw();
            }


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



            Console.ReadLine();
        }
    }
}