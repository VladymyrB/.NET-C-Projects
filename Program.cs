using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2
{
    class Program
    {
        static void Main(string[] args)
        {
            double Sum = 0.0;
            double Product = 1;
            int NN = 0;
            int NM = 0;
            do
            {
                Console.WriteLine("NN: ");
                NN = Int32.Parse(Console.ReadLine());
                Console.WriteLine("NM: ");
                NM = Int32.Parse(Console.ReadLine());
            } while (NN < 0 && NM < 0);

            
           

                for (int i = NN; i <= NM; i++)
                {
                    Sum += ((i ^ 2) - ((-1) ^ (i + 1)) * i ^ 3) / ((i ^ 2) + i + 1);
                }
                for (int i = NN; i <= NM; i++)
                {
                    Product *= ((i ^ 2) - ((-1) ^ (i + 1)) * i ^ 3) / ((i ^ 2) + i + 1);
                }

                Console.WriteLine($"Сума ряда: {Sum}  ");
                Console.WriteLine($"Произведение ряда: {Product}  ");
                Console.ReadLine();

            
         

        }
    }
}
