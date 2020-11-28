using System;
using System.Collections.Generic;
using System.Text;

namespace Lab11_1
{
    public class Patient
    {
        public bool MrtIsDone { get; set; }
        public bool KtIsDone { get; set; }
        public bool RoentgenIsDone { get; set; }
        public bool EntIsPassed { get; set; }
        public bool UziIsDone { get; set; }
        public bool RheumoIsDone { get; set; }

        public void ViewResults()
        {
            Console.WriteLine($"MRT: {MrtIsDone}");
            Console.WriteLine($"KT: {KtIsDone}");
            Console.WriteLine($"Roentgen: {RoentgenIsDone}");
            Console.WriteLine($"Ent: {EntIsPassed}");
            Console.WriteLine($"Uzi: {UziIsDone}");
            Console.WriteLine($"Rheumo: {RheumoIsDone}");
        }
    }
}
