// See https://aka.ms/new-console-template for more information
using Tetris;
internal class Program
{
    private static void Main(string[] args)
    {
        {
            Console.SetWindowSize(40, 30);
            Console.SetBufferSize(40, 30);

            int x1 = 2;
            int y1 = 3;
            char c1 = '*';

            Point p1 = new Point();
            p1.x = 2;
            p1.y = 3;
            p1.c = '*';
            p1.Draw();



            Console.ReadLine();
        }
    }
}