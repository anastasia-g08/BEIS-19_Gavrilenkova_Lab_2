using System;

namespace LR2
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.Write("Введите значение х = ");
                double x = double.Parse(Console.ReadLine());
                double f1, f2;
                if (x >= 2)
                {
                    f1 = (1.0 / 7.0 + Math.Log(Math.Sqrt(x)));
                    f2 = Math.Exp(Math.Sqrt(x - 2));
                    Console.Write("Ответ: " +  f1*f2);

                }
                else
                    Console.WriteLine("Введенное значение не входит в область допустимых значений");                
            }
            catch (Exception)
            {
                Console.WriteLine("\n\nВведенное значение некорректно");
                Console.ReadKey();
            }
        }
    }
}
