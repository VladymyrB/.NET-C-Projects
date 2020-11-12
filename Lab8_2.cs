using System;

namespace Lab8_2
{
    class Program
    {
        static void Main(string[] args)
        {
            var phone = new SmartPhone();
            var phone2 = new ButtonPhone() { PhoneNumber = "2342342" };
            phone.GetCall(phone2);
            Console.ReadLine();
        }
    }
}
