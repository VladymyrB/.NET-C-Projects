using Lab9_3;
using System;
using System.Collections.Generic;
using System.Text;

namespace Lab9_1._1
{
    public class Circle : Shape, IDraw
    {
        public override Colors Color { get; set; }

        public override int SummitAmount { get; } = 0;

        public override string Name { get; }
        public double Radius { get; }

        public Circle(string Name)
        {
            this.Name = Name;
            Color = Colors.White;
            Radius = new Random().NextDouble() * 100;
        }
        public Circle(string Name, double Radius) : this(Name)
        {
            this.Radius = Radius;
        }
        public Circle(string Name, double Radius, Colors color) : this(Name, Radius)
        {
            this.Color = color;
        }
        public override double Perimeter()
        {
            return 2 * Math.PI * Radius;
        }

        public override double GetSquare()
        {
            return Math.PI * Radius * Radius;
        }

        public void Draw()
        {
            Console.WriteLine($"Color: {Color}");
            Console.WriteLine($"Name: {Name}");
            Console.WriteLine($"Radius: {Radius}");
        }
    }
}
