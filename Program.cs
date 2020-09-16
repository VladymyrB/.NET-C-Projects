using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3
{
    class Program
    {
        static void Main(string[] args)
        {
            
                Console.WriteLine("Enter x: ");
                int x = Int32.Parse(Console.ReadLine());
                Console.WriteLine("Enter y: ");
                int y = Int32.Parse(Console.ReadLine());

        
            
            if ((x > 0 && y > 0) || (x < 0 && y < 0))
            {
                Console.WriteLine(true);
                Console.ReadLine();
            }
            else
            {
                Console.WriteLine(false);
                Console.ReadLine();
            }
        }
    }
}
