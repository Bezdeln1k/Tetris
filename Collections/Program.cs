using System;
using Tetris;

public class Program
{
    static void Main(string[] args)
    {
        //int[] nums1 = new int[5];
        //nums1[0] = 1;
        //nums1[1] = 2;

        //for (int i = 0; i < nums1.Length; i++)
        //{
        //    Console.WriteLine(nums1[i]);
        //}

        //foreach(int i in nums1) //аналогично циклу for, только гораздо компактнее для массивов
        //{
        //    Console.WriteLine(i);
        //}

        //Point[] points = new Point[3];
        //points[0] = new Point(1, 2, '*');
        //points[1] = new Point(3, 4, '#');
        //points[2] = new Point(5, 6, '*');

        //foreach(Point p in points)
        //{
        //    p.Draw();
        //}

        char[][] field = new char[9][]; //попытался сделать квадрат из звездочек
        field[0] = new char[9];
        field[1] = new char[9];
        field[2] = new char[9];
        field[3] = new char[9];
        field[4] = new char[9];
        field[5] = new char[9];
        field[6] = new char[9];
        field[7] = new char[9];
        field[8] = new char[9];

        field[0][0] = '*';
        field[0][1] = '*';
        field[0][2] = '*';
        field[1][0] = '*';
        field[1][1] = '*';
        field[1][2] = '*';
        field[2][0] = '*';
        field[2][1] = '*';
        field[2][2] = '*';

        for (int i = 0; i < field.Length; i++)
        {
            for (int j = 0; j < field[i].Length; j++)
            {
                Console.Write(field[i][j]);
            }
            Console.WriteLine();
        }


        Console.ReadLine();
    }
}