using System;
using System.Collections.Generic;
using System.Text;

namespace Lab8_2
{
    class SmartPhone: ColoredScreenPhone
    {
        public bool SensorManage { get; set; }
        public int MaxTouchAmout { get; set; }
        public List<string> Camers { get; } = new List<string> { "Front Camera", "Main Camers" };
        public void TakePicture()
        {
            Console.WriteLine("Choose camera: ");
            if (Console.ReadLine() == "Front camera" ||
                Console.ReadLine() == "front camera" ||
                Console.ReadLine() == "Front" ||
                Console.ReadLine() == "front")
            {
                Console.WriteLine("Picture was taken by front-camera");
            }
            else if (
                Console.ReadLine() == "Main camera" ||
                Console.ReadLine() == "main camera" ||
                Console.ReadLine() == "Main" ||
                Console.ReadLine() == "main"
                )
            {
                Console.WriteLine("Picture was taken by main-camera");
            }
                
        }
    }
}
