using Lab9_3;
using System;
using System.Collections.Generic;
using System.Text;

namespace Lab9_1._1
{
    public class Triangle : Shape, IDraw
    {
        public override Colors Color { get; set; }

        public override int SummitAmount { get; } = 3;

        public  double SideLengthA { get; }
        public  double SideLengthB { get; }
        public  double SideLengthC { get; }
        public override string Name { get; }

        public Triangle(string Name)
        {
       
            this.Name = Name;

            SideLengthA = new Random().Next(1,100);

            SideLengthB = new Random().Next(1,100);

            SideLengthC = new Random().Next(1, (int)(SideLengthA + SideLengthB));
        }
        public Triangle(string Name, double SideLengthA, double SideLengthB, double SideLengthC) : this(Name)
        {
            if (SideLengthA < SideLengthB + SideLengthC || SideLengthB < SideLengthA + SideLengthC || SideLengthC < SideLengthA + SideLengthB)
            {
                this.SideLengthA = SideLengthA;

                this.SideLengthB = SideLengthB;

                this.SideLengthC = SideLengthC;

                Color = Colors.White;
            }
            else
            {
                throw new Exception("The sides do not represent a triangle");
            }

            
        }
        public Triangle(string Name,Colors color, double SideLengthA, double SideLengthB, double SideLengthC):
            this(Name, SideLengthA, SideLengthB, SideLengthC)
        {
            this.Color = color;
        }
       
        public override double Perimeter()
        {
            return SideLengthA + SideLengthB + SideLengthC;
        }

        public override double GetSquare()
        {
            double HalfPerimeter = (SideLengthA + SideLengthB + SideLengthC) / 2;

            return
                Math.Sqrt(
                    HalfPerimeter * (HalfPerimeter - SideLengthA) * (HalfPerimeter - SideLengthB) * (HalfPerimeter - SideLengthC));
        }

        public void Draw()
        {
            Console.WriteLine($"Color: {Color}");
            Console.WriteLine($"Name: {Name}");
            Console.WriteLine($"Side A: {SideLengthA}");
            Console.WriteLine($"Side B: {SideLengthB}");
            Console.WriteLine($"Side C: {SideLengthC}");
        }
    }
}
