using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;

namespace Lab
{
    class Program
    {
        static void Main(string[] args)
        {
            List<char> CharList = new List<char>();
            FillList(CharList);
            char[] CharArray = new char[CharList.Count];
            ListToArray(CharList, ref CharArray); 
           
            Console.ReadLine();
        }

        static void ListToArray( in List<Char> CharList, ref char[] CharArray )
        {
             for(int i = 0; i < CharList.Count; i++)
            {
                CharArray[i] = CharList[i];
            }
            Console.WriteLine("CharArray: ");
            for (int i = 0; i < CharArray.Length; i++)
            {
                Console.WriteLine("Char: " + CharArray[i] + ";" + "Index: " + i + ";");
            }
        }
        static void FillList(  List<char> CharList  )
        {
            while (true)
            {
                Console.WriteLine("Put char in char list(y/n)?: ");
                if( Console.ReadLine() == "y" || Console.ReadLine() == "Y")
                {
                    Console.WriteLine("Your char: ");
                    char ch = Convert.ToChar(Console.ReadLine());
                    CharList.Add(ch);
                }
                else
                {
                    break;
                }
               
            }
            Console.WriteLine("CharList: ");
            for (int i = 0; i < CharList.Count; i++)
            {
                Console.WriteLine("Char: " + CharList[i] + ";" + "Index: " + i + ";");
            }
        }

    }
}
