using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Array Length(N): ");
            int length = Int32.Parse(Console.ReadLine());
            int[] Arr = new int[length];
            int last=0, first=0;
            for(int i = 0; i < Arr.Length; i++)
            {
                Arr[i] = Int32.Parse(Console.ReadLine());
            }
            for(int i = 0; i < Arr.Length; i++)
            {
                if (Arr[i] > Arr[1] && Arr[i] > Arr[Arr.Length - 1]) {

                    first = i+1;
                    break;

                } ;
            }
            for(int i = 0; i < Arr.Length; i++)
            {
                if((Arr[i] > Arr[1] && Arr[i] < Arr[Arr.Length - 1])&& last >= first)
                {
                    last = i;
                    
                }

            }
            if (first == 0 && last == 0) { Console.WriteLine("No elements for such task");Console.ReadLine(); }
            else
            {
                Console.WriteLine($"First: {first} ");
                Console.WriteLine($"Last: {last}");
                Console.ReadLine();
            }
            

        }
    }
}
