using System;
using System.Collections.Generic;

namespace Lab2CS
{
    class Program
    {
        static void Main(string[] args)
        {
           
            Console.ReadLine();
        }
        
        static int InputInt()
        {
            string str = Console.ReadLine();
            int number = 0;
            try
            {
                number = Convert.ToInt32(str);
            }
            catch (Exception)
            {

                throw;
            }
            return number;
        }       
        static void ReverseIntByCycle()
        {
            int number = InputInt();
            int TempNum=0;
            while (true)
            {
               
                TempNum = number % 10;
                Console.Write(TempNum);
                if (number / 10 < 1)
                {

                    break;
                }
                number /= 10;
                
            }
           


        }
        static void ReverseIntByRecursion(int number)
        {
            
            int TempNum = 0;
            TempNum = number % 10;
            Console.Write(TempNum);
            if (number / 10 < 1)
            {
                
                return;
            }
            ReverseIntByRecursion(number / 10);

            



        }
        static void ReverseStringByCycle(string str)
        {
           for(int i = str.Length-1; i >=0; i--)
            {
                Console.Write(str[i]);
            }



        }
        static string ReverseStringByRecursion(string str)
        {
            string leftPart, rightPart;
            if (str.Length <= 1)
            {
               
                return str;
            }
            leftPart = str.Substring(0, str.Length/2);
            rightPart = str.Substring(str.Length/2,(str.Length+1)/2);
           
            return ReverseStringByRecursion(rightPart) + ReverseStringByRecursion(leftPart);
            
        }
        static void ReverseDoubleByCycle(double number)
        {
            
            string str = number.ToString();
            int BeforePoint=0 , AfterPoint=0;
            for(int i = 0; i < str.Length; i++)
            {
                if (str[i] == ',')
                {
                    BeforePoint = i - 1;
                    AfterPoint = i + 1;
                }

            }
            for(int i = BeforePoint; i>=0; i--)
            {
                Console.Write(str[i]);
            }
            Console.Write(",");
            for(int i = str.Length - 1; i >= AfterPoint;i--)
            {
                Console.Write(str[i]);
            }
        }
        static void ReverseDoubleByRecursion(double number)
        {
            string str = number.ToString();
            int BeforePoint = 0, AfterPoint = 0;
            for (int i = 0; i < str.Length; i++)
            {
                if (str[i] == ',')
                {
                    BeforePoint = i - 1;
                    AfterPoint = i + 1;
                }

            }        
            string LeftPart = str.Substring(0, BeforePoint + 1);
            string RightPart = str.Substring(AfterPoint, str.Length - AfterPoint);
           

            Console.WriteLine( ReverseStringByRecursion(LeftPart)+ "," + ReverseStringByRecursion(RightPart)  );
        }
        static void ReverseStringWithSignByCycle(string str,char sign)
        {
            int BeforePoint = 0, AfterPoint = 0;
            for (int i = 0; i < str.Length; i++)
            {
                if (str[i] == sign)
                {
                    BeforePoint = i - 1;
                    AfterPoint = i + 1;
                }

            }
            for (int i = BeforePoint; i >= 0; i--)
            {
                Console.Write(str[i]);
            }
            Console.Write(",");
            for (int i = str.Length - 1; i >= AfterPoint; i--)
            {
                Console.Write(str[i]);
            }


        }
        static void ReverseStringWithSignByRecursion(string str,char sign)
        {
            int BeforePoint=0, AfterPoint=0;
            for (int i = 0; i < str.Length; i++)
            {
                if (str[i] == sign)
                {
                    BeforePoint = i - 1;
                    AfterPoint = i + 1;
                }

            }
            string LeftPart = str.Substring(0, BeforePoint + 1);
            string RightPart = str.Substring(AfterPoint, str.Length - AfterPoint);
           

            Console.WriteLine(ReverseStringByRecursion(LeftPart) + "," + ReverseStringByRecursion(RightPart));
        }
        static void ReverseArray( ref int[] array, out int[] ResArray )
        {
          
            ResArray = new int[array.Length];
            for(int i = 0,j = array.Length-1; i < array.Length&&j>=0; i++,j--)
            {
                ResArray[j] = array[i];
            }    
        }
    }
}
