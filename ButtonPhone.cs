using System;
using System.Collections.Generic;
using System.Text;

namespace Lab8_2
{
    class ButtonPhone: DiscPhone
    {
        public override List<char> CharSet { get; protected set; } = new List<char> { '0', '1', '2', '3', '4', '5', '6', '7', '8', '9','*','&' };

        public override void GetCall(DiscPhone phone )
        {
            Console.WriteLine($"Calling number: {phone.PhoneNumber}");
        }
    }
}
