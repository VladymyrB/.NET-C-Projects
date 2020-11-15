using System;
using System.Collections.Generic;
using System.Net.Http.Headers;
using System.Text;

namespace Lab8_2
{
    class ColoredScreenPhone: NotColoredScreenPhone
    {
        public List<string> ScreenColors { get; } = new List<string> { };
        public List<string> SimCards { get; } = new List<string> { "First", "Second" };
        public override void MakeCall()
        {
            Console.WriteLine("Choose Sim-Card: ");
            if(Console.ReadLine() == "1" || Console.ReadLine() == "First")
                Console.WriteLine("Call was made by first Sim-Card");
            else if(Console.ReadLine() == "2" || Console.ReadLine() == "Second")
                Console.WriteLine("Call was made by second Sim-Card");
            else
                Console.WriteLine("Sim-Card wasn't found");

        }
        public override void SendMsg()
        {
            Console.WriteLine("Choose Sim-Card: ");
            if (Console.ReadLine() == "1" || Console.ReadLine() == "First")
                Console.WriteLine("Msg was sent by first Sim-Card");
            else if (Console.ReadLine() == "2" || Console.ReadLine() == "Second")
                Console.WriteLine("Msg was sent by second Sim-Card");
            else
                Console.WriteLine("Sim-Card wasn't found");
        }
        public void MakeMMS()
        {
            Console.WriteLine("Choose Sim-Card: ");
            if (Console.ReadLine() == "1" || Console.ReadLine() == "First")
                Console.WriteLine("MMS was sent by first Sim-Card");
            else if (Console.ReadLine() == "2" || Console.ReadLine() == "Second")
                Console.WriteLine("MMS was sent by second Sim-Card");
            else
                Console.WriteLine("Sim-Card wasn't found");
        }
        public void GetMMS()
        {
            Console.WriteLine("MMS was gotten");
        }
    }
}
