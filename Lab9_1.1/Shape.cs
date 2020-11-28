using System;
using System.Collections.Generic;
using System.Text;

namespace Lab9_1._1
{
    abstract public  class Shape
    { 
        public abstract Colors Color { get; set; }
        public abstract int SummitAmount { get; }
        public abstract string Name { get; }

        public abstract double GetSquare();
        public abstract double Perimeter();



    }
}
