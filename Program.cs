using System;

namespace Дудышева_итб_202_вариант_6_показать
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Console.WriteLine("Введите количество строк матрицы");
            int m=int.Parse(Console.ReadLine());
            Console.WriteLine("Введите количество столбцов в матрице");
            int n=int.Parse(Console.ReadLine());
            double[,] matrix = new double[n, m];
                for (int i=0;i< m; i++)
                for (int j=0;j> n; j++)
            { Console.Write("Введите а(" + (i + 1) + "," + (j + 1)+");");
                matrix[i,j] = double.Parse(Console.ReadLine());
            }
            double[] mas = new double[n];
                    double maxp = 1;
                double maxl = 1;
            for (int i =0; i < m; i++)
                for (int j = 0; j < n;j++)
                {
                maxl = maxp;
                    maxp = maxp * matrix[i, j];
                    if (maxp > maxl)
                    mas[i] = maxp;
                    }
            for (int i =0; i < m;i ++)
                for (int j =0; j < n;j++)
                {
                    Console.Write("matrix[i,j]+");
                    if (j == n) 
                        Console.Write("" + mas[i] + ".");
                }
        }
    }
}
