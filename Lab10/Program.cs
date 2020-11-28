using System;

namespace Lab10
{
     class Program
    {
        static void Main(string[] args)
        {
            int[] arr = new int[] { 1,2,3,4,5 };

            arr.IntArrayExtention(out int min, out int max);
            Console.WriteLine(min);
            Console.WriteLine(max);
        }
         
    }
    public static class Extention
    {
       public static void IntArrayExtention(this int[] arr, out int MinValue, out int MaxValue)
        {
            MinValue = int.MaxValue;
            MaxValue = int.MinValue;

            for (int i = 0; i < arr.Length; i++)
            {
                if(arr[i] < MinValue)
                {
                    MinValue = arr[i];
                }

                if(arr[i] > MaxValue)
                {
                    MaxValue = arr[i];
                }
            }
        }
    }

   
}
