using System;
using System.Collections.Generic;
using System.Text;

namespace IndependantWork_11._11._2020
{
   
    
    public class Car
    {
        public decimal Price { get; set;  }
        public int Year
        {
            get
            {
                return Year;
            }
            set
            {
                if(value <= DateTime.Now.Year)
                {
                    Year = value;
                }
                else
                {
                    Console.WriteLine("Not appropriate year");
                }
            }
        }
        public List<string> Colors { get; set;  }
        public string Name { get; set; }
    }
}
