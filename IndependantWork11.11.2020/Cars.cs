using System;
using System.Collections.Generic;
using System.Text;

namespace IndependantWork_11._11._2020
{
    public class Cars
    {
        private readonly List<Car> _Cars = new List<Car>
        {
            new Car { Colors = new List<string> { "red","blue" },Price = 51.121m,Name = "BMW",Year=2009 },
            new Car { Colors = new List<string> { "red","yellow" },Price = 11.121m,Name = "VAZ",Year=2008 },
            new Car { Colors = new List<string> { "black","red" },Price = 11.121m,Name = "AUDI",Year=2019 },
            new Car { Colors = new List<string> { "red","yellow" },Price = 21.121m,Name = "Mercedes",Year=2018 }
        };
        public void PrintCarInfo(Car car)
        {
            Console.WriteLine("There is such car: ");
            Console.WriteLine($"Name: {car.Name}");
            Console.WriteLine($"Color: " );

            foreach (var color in car.Colors)
            {
                Console.WriteLine(color);
            }

            Console.WriteLine($"Price: {car.Price}");
            Console.WriteLine($"Year: {car.Year}");
        }
        private void SearchForCar(Car searchedCar)
        {
            
            for (int i = 0; i < _Cars.Count; i++)
            {
                if
                    (
                    searchedCar.Name == _Cars[i].Name && 
                    searchedCar.Price == _Cars[i].Price && 
                    searchedCar.Year == _Cars[i].Year &&
                    _Cars[i].Colors.Contains(searchedCar.Colors[0])
                    )
                {
                    PrintCarInfo(searchedCar);
                    return;
                }


            }
            Console.WriteLine("No such cars");
            
        }
        public void GetCar()
        {
            var searchedCar = new Car();
            Console.WriteLine("Select features for car: ");
            Console.WriteLine("Name: ");
            searchedCar.Name = Console.ReadLine();
            Console.WriteLine("Year: ");

            try
            {
               
                searchedCar.Year = Convert.ToInt32(Console.ReadLine());
            }
            catch (Exception ex)
            {
                searchedCar.Year = 0;
                Console.WriteLine(ex.Message);
            }

            Console.WriteLine("Color: ");
            searchedCar.Colors = new List<string> { Console.ReadLine() };

            Console.WriteLine("Price: ");
            try
            {
                searchedCar.Price = Convert.ToDecimal(Console.ReadLine());
            }
            catch(Exception ex)
            {
                searchedCar.Price = 0.0m;
                Console.WriteLine(ex.Message);
            }

            SearchForCar(searchedCar);
        }
    }
}
