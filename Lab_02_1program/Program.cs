using System;

namespace Lab_02_1program
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Write a, b and c for equation ax^2+bx+c = 0");
                Console.Write("a = ");
                float coefficient_a = Convert.ToSingle(Console.ReadLine());
                Console.Write("b = ");
                float coefficient_b = Convert.ToSingle(Console.ReadLine());
                Console.Write("с = ");
                float coefficient_с = Convert.ToSingle(Console.ReadLine());
                double unknown_x_1 = 0;
                if (coefficient_a != 0 && coefficient_b != 0 && coefficient_с != 0)
                {
                    double D = Math.Pow(coefficient_b, 2) - (4 * coefficient_a * coefficient_с);
                    Console.WriteLine(D);
                    if (D < 0)
                    {
                        Console.WriteLine($"The result is {coefficient_a}x^2 + {coefficient_b}x + {coefficient_с} = 0;");
                        Console.ReadKey();
                    }
                    else if (D == 0)
                    {
                        unknown_x_1 = -1*coefficient_b / (2 * coefficient_a);
                        Console.WriteLine($"The result is x = {unknown_x_1}");
                        Console.ReadKey();
                    }
                    else if (D > 0)
                    {
                        unknown_x_1 = (1*-coefficient_b + Math.Sqrt(D)) / (2 * coefficient_a);
                        double unknown_x_2 = (-1*coefficient_b - Math.Sqrt(D)) / (2 * coefficient_a);
                        Console.WriteLine($"The results are x1 = {unknown_x_1}\nx2 = {unknown_x_2}");
                        Console.ReadKey();
                    }
                }
                else if (coefficient_a == 0)
                {
                    if (coefficient_с != 0 && coefficient_b == 0)
                    {
                        Console.WriteLine("This equation doesn't have decisions");
                        Console.ReadKey();
                    }
                    else if (coefficient_b == 0 && coefficient_с == 0)
                    {
                        Console.WriteLine("This equation doesn't have decisions");
                        Console.ReadKey();
                    }
                    else if (coefficient_b != 0 && coefficient_с == 0)
                    {
                        unknown_x_1 = 0;
                        Console.WriteLine($"The result is x = {unknown_x_1}");
                        Console.ReadKey();
                    }
                    else if (coefficient_b != 0 && coefficient_с != 0)
                    {
                        unknown_x_1 = -1 * (coefficient_с / coefficient_b);
                        Console.WriteLine($"The result is x = {unknown_x_1}");
                        Console.ReadKey();
                    }
                }
                else if (coefficient_b == 0)
                {

                    unknown_x_1 = Math.Sqrt(Math.Abs(-1 * (coefficient_с / coefficient_a)));
                    double unknown_x_2 = -1*(Math.Sqrt(Math.Abs(-1 * (coefficient_с / coefficient_a))));
                    Console.WriteLine($"The results are x1 = {unknown_x_1}\nx2 = {unknown_x_2}");
                    Console.ReadKey();
                }
                else if (coefficient_с == 0)
                {
                    unknown_x_1 = 0;
                    double unknown_x_2 = -1 * (coefficient_b / coefficient_a);
                    Console.WriteLine($"The results are x1 = {unknown_x_1}\nx2 = {unknown_x_2}");
                    Console.ReadKey();
                }
            }
            catch
            {
                Console.WriteLine("Oops.. that's error. Try again");
                Console.ReadKey();
            }
        }
    }
}
