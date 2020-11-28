using Lab9_3;
using System;
using System.Collections.Generic;
using System.Text;

namespace Lab9_1._1
{
    public enum Colors
    {
        Red,
        White,
        Black,
        Pink
    }
    public class Square : Shape, IDraw
    {
        public override Colors Color { get ; set ; }

        public  override int SummitAmount { get; } = 4;

        public override string Name { get;  }
        public double SideLength { get;  }

        public Square(string Name)
        {
            this.Name = Name;
            SideLength = new Random().NextDouble() * 100;
            Color = Colors.White;
        }
        public Square(string Name,double SideLength) : this(Name)
        {
            this.SideLength = SideLength;
          
        }
        public Square(string Name, double SideLength, Colors color): this(Name,  SideLength)
        {
            this.Color = color;
        }
        public override double Perimeter()
        {
            return SideLength * SummitAmount;
        }

        public override double GetSquare()
        {
            return SideLength * SideLength;
        }

        public void Draw()
        {
            Console.WriteLine($"Color: {Color}");
            Console.WriteLine($"Name: {Name}");
            Console.WriteLine($"Radius: {SideLength}");
        }
    }
}
