using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T_CHAAAAAAAAA
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите накопления студента: ");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите стипендию студента: ");
            int b = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите расходы студента: ");
            double c = double.Parse(Console.ReadLine());
            int m = 0;
            for (double i = a; i > c; i += b)
            {
                i -= c;
                c += c * 0.03;
                m++;
            }
            Console.WriteLine(m + " месяцев сможет прожить студент");
            Console.ReadKey();
        }
    }
}
