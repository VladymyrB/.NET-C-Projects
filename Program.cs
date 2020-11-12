using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Reflection.Metadata.Ecma335;

namespace Lab8
{
    class Car
    {
        public string Name { get; set; }
        public string Color { get; set; }
        public double MaxSpeed {
            get;set;
           
        }
        public int Year {
            get;set;
           
        }

    }
    class SheikhGarage
    {
        public List<Car> Cars { get; set; } = new List<Car>
        {
            new Car
            {
                Name="sd",
                MaxSpeed = 123,
                Color = "asda",
                Year = 213212
            },
             new Car
            {
                Name="sd",
                MaxSpeed = 123,
                Color = "asd",
                Year = 2132
            },
              new Car
            {
                Name="sd",
                MaxSpeed = 123,
                Color = "asd",
                Year = 213221
            },
               new Car
            {
                Name="sd",
                MaxSpeed = 123,
                Color = "asda",
                Year = 2132
            }
        };
        private List<Car> _SearchedCars = new List<Car>();
        //private Car _SearchedCar = new Car();
        public void AddCar()
        {
            Car car = new Car();
            Console.WriteLine("Add new car: ");
            Console.WriteLine("Name: ");
            car.Name = Console.ReadLine();
            if (car.Name == "")
                car.Name = "Wasn't mentioned";
            Console.WriteLine("MaxSpeed");
            try
            {
                car.MaxSpeed = Convert.ToDouble(Console.ReadLine());
            }
            catch
            {
                car.MaxSpeed = 0;
            }
            Console.WriteLine("Color: ");
            car.Color = Console.ReadLine();
            if (car.Color == "")
                car.Color = "Wasn't mentioned";
            Console.WriteLine("Year: ");
            try
            {
                car.Year = Convert.ToInt32(Console.ReadLine());
            }
            catch
            {
                car.Year = 0;
            }



        }
        public void DeleteCars()
        {
            Console.WriteLine("Features of car for deleting: ");
            List<Car> CarsForDeleting =  SearchForCars();
            Console.WriteLine("Are you sure about deleting?(y/n)");
            if(Console.ReadLine() == "Y" || Console.ReadLine() == "y")
            {
                for(int i = 0; i < CarsForDeleting.Count; i++)
                {
                    Cars.Remove(CarsForDeleting[i]);
                }
            }
            else
            {
                Console.WriteLine("Deleteing was stopped");
            }
        }
        public List<Car> SearchForCars()
        {
            Car SearchedCar = new Car();
            Console.WriteLine("Name: ");
            SearchedCar.Name = Console.ReadLine();
            Console.WriteLine("MaxSpeed");
            try
            {
                SearchedCar.MaxSpeed = Convert.ToDouble(Console.ReadLine());
            }
            catch
            {
                SearchedCar.MaxSpeed = 0.0;
            }
            Console.WriteLine("Color: ");
            SearchedCar.Color = Console.ReadLine();
            Console.WriteLine("Year: ");
            try
            {
                SearchedCar.Year = Convert.ToInt32(Console.ReadLine());
            }
            catch
            {
                SearchedCar.Year = 0;
            }
            
            
            PrintCars(_SearchedCars);
            return CarsSelection(SearchedCar, _SearchedCars);
        }
        private List<Car> CarsSelection(Car car,List<Car> _SearchedCars)
        {
            for (int i = 0; i < Cars.Count; i++)
            {
                if (Cars[i].Name == car.Name || car.Name == "")
                {
                    if(Cars[i].Color == car.Color || car.Color == "")
                    {
                        if(Cars[i].MaxSpeed == car.MaxSpeed || car.MaxSpeed == 0)
                        {
                            if(Cars[i].Year == car.Year)
                            {
                                _SearchedCars.Add(Cars[i]);
                            }
                            else if( (Cars[i].Name == car.Name || Cars[i].Color == car.Color || Cars[i].MaxSpeed == car.MaxSpeed) && car.Year == 0)
                            {
                                _SearchedCars.Add(Cars[i]);
                            }
                        }
                    }
                }

    
            }
            return _SearchedCars;
        }
        private void PrintCars(List<Car> Cars)
        {
            for(int i = 0; i < Cars.Count; i++)
            {
                Console.WriteLine("Car" + i + 1 + ": ");
                Console.WriteLine("Name" + Cars[i].Name);
                Console.WriteLine("Color: " + Cars[i].Color);
                Console.WriteLine("MaxSpeed: " + Cars[i].MaxSpeed);
                Console.WriteLine("Year: " + Cars[i].Year);
                Console.WriteLine();
            }
        }

    }


    class Program
    {
        static void Main(string[] args)
        {
            SheikhGarage garage = new SheikhGarage();
            garage.SearchForCars();
            Console.ReadLine();
        }
    } 

   
}
