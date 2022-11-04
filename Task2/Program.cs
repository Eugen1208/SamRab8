using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string path = @"C:\Users\User\Desktop\Учеба REVIT\C#\Урок 8\Numbers.txt";
            Random random = new Random();
            using (StreamWriter sw = new StreamWriter(path, false))
            {
                for (int i = 0; i < 10; i++)
                {
                    sw.WriteLine(random.Next(-20, 20));
                }
            }
            int[] array = new int[10];
            int index = 0;
            int sum = 0;
            using (StreamReader sr = new StreamReader(path))
            {
                while (index < 10)
                {
                    array[index] = random.Next(-20, 20);
                    sum = sum + array[index];
                    Console.WriteLine(array[index]);
                    index++;
                }
                Console.WriteLine("Сумма: " + sum);
                Console.ReadKey();
            }
        }
    }
}
