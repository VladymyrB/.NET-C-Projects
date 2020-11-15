using System;
using System.Collections.Generic;
using System.Text;

namespace Lab8_2
{
    public class DiscPhone
    {
        public string PhoneNumber { get; set; }
        public virtual List<char> CharSet { get; protected set; } = new List<char> {'0', '1','2', '3', '4', '5', '6', '7', '8', '9' };
        public virtual void MakeCall ()
        {
            Console.WriteLine("Call was made");
        }
        public virtual void GetCall(DiscPhone phone)
        {
            Console.WriteLine("Call was gotten");
        }

    }
} 
