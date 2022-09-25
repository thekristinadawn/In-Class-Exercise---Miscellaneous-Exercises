using System;

namespace In_Class_Exercise___Miscellaneous_Exercises_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int sizeArray;
            Console.WriteLine("Enter Size of Array:");
            sizeArray = Convert.ToInt32(Console.ReadLine());
            int[] Array1 = new int[sizeArray];

            for (int i = 0; i < sizeArray; i++)
            {
                Array1[i] = Convert.ToInt32(Console.ReadLine());
            }

            //for (int i = 0;i < sizeArray; i++)
            //{
                //Console.WriteLine(Array1[i]);
            //}

        }
    }
}
