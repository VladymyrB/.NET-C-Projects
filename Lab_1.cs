using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_1_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Напруга: ");
            double Voltage = Double.Parse(Console.ReadLine());
            Console.WriteLine("Сила току: ");
            double CurrentStrength = Double.Parse(Console.ReadLine());
            Console.WriteLine("Сопротевление:" + Voltage/CurrentStrength);
            Console.ReadLine();
        }
    }
}
