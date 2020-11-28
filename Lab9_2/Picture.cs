using Lab9_1._1;
using Lab9_3;
using System;
using System.Collections.Generic;
using System.Text;

namespace Lab9_2
{
    public class Picture: IDraw
    {
        private List<Shape> _shapes = new List<Shape>();
        public int ShapesLength { get; protected set; } 
        public Picture()
        {
            ShapesLength = _shapes.Count;

        }
       
        public void AddShape(Shape shape)
        {
            ShapesLength++;
            _shapes.Add(shape);
        }
        public void DeleteShape(string shapeName)
        {
            foreach (var shape in _shapes)
            {
                if(shape.Name == shapeName)
                {
                    _shapes.Remove(shape);
                    ShapesLength--;
                }
            }
        }
        public void DeleteShape(double MaxSquare)
        {
            foreach (var shape in _shapes)
            {
                if(shape.GetSquare() > MaxSquare)
                {
                    _shapes.Remove(shape);
                    ShapesLength--;
                }
            }
        }

        public void Draw()
        {
            foreach (var shape in _shapes)
            {

                Console.WriteLine($"Color: {shape.Color}");
                Console.WriteLine($"Name: {shape.Name}");
                Console.WriteLine($"Square: {shape.GetSquare()}");
            }
        }

      
        public Shape this[int index] {
            get
            {
                return _shapes[index];
            } 
        }
    }
}
