using System;

namespace ОХ_ОХ
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            {
                Console.WriteLine("Введите высоту ребра куба: ");
                double h = Convert.ToDouble(Console.ReadLine());
                Console.Write("\n");
                Console.Write("Высота ребра куба = {0}\n", h);
                double s = 6 * (h * h);
                double v = h * h * h;
                Console.Write("Площадь куба = {0} , объем куба = {1}", s, v);
                Console.ReadLine();
            }
        }
    }
}
