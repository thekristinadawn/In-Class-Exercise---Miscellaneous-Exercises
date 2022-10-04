using System;
using System.Collections.Generic;
using System.Linq;


namespace In_Class_Exercise___Miscellaneous_Exercises_
{
    internal class Program
    {
        //Exercise 1 - Increasing Adjacent Numbers -    COMPLETED
        static void AdjacentNumbers()
        {
            int sizeArray;
            Console.WriteLine("Enter size of array:");
            sizeArray = Convert.ToInt32(Console.ReadLine());
            int[] array = new int[sizeArray];
            Console.WriteLine("Enter Numbers:");
            for (int i = 0; i < sizeArray; i++)
            {
                array[i] = Convert.ToInt32(Console.ReadLine());
            }

            bool threeAdjacent = false;
            for (int i = 0; i < sizeArray - 2; i++)
            {
                if (array[i] == array[i + 1] - 1 && array[i] == array[i + 2] - 2)

                {
                    threeAdjacent = true;
                    Console.WriteLine(threeAdjacent); ;
                    break;
                }
                threeAdjacent = false;
                Console.WriteLine(threeAdjacent);
                break;

            }
        }


        //Exercise 2 : Two-Dimensional array Average -- COMPLETE
        static void Main(string[] args)
        {
            int[] studentGroup1 = new int[5];
            int sizeGroup1 = 5;
            Console.WriteLine("Enter grades for Student Group 1:");
            for (int i = 0; i < sizeGroup1; i++)
            {
                studentGroup1[i] = Convert.ToInt32(Console.ReadLine());
            }
            int[] studentGroup2 = new int[5];
            int sizeGroup2 = 5;
            Console.WriteLine("Enter grades for Student Group 2:");
            for (int i = 0; i < sizeGroup2; i++)
            {
                studentGroup2[i] = Convert.ToInt32(Console.ReadLine());
            }

            double avgGroup1 = Queryable.Average(studentGroup1.AsQueryable());
            Console.WriteLine(("Average for Group 1 is:" + " " + avgGroup1));
            double avgGroup2 = Queryable.Average(studentGroup2.AsQueryable());
            Console.WriteLine(("Average for Group 1 is:" + " " + avgGroup2));
        }

        //Exercise 3 : Difference of arrays  -  COMPLETED
        static void Main(string[] args)
        {
            int sizeArray1;
            Console.WriteLine("Enter Size of Array:");
            sizeArray1 = Convert.ToInt32(Console.ReadLine());
            int[] array1 = new int[sizeArray1];
            Console.WriteLine("Enter numbers:");
            for (int i = 0; i < sizeArray1; i++)
            {
                array1[i] = Convert.ToInt32(Console.ReadLine());
            }

            int sizeArray2;
            Console.WriteLine("Enter Size of Array:");
            sizeArray2 = Convert.ToInt32(Console.ReadLine());
            int[] array2 = new int[sizeArray2];
            Console.WriteLine("Enter numbers:");
            for (int i = 0; i < sizeArray2; i++)
            {
                array2[i] = Convert.ToInt32(Console.ReadLine());
            }
            //int[] arrayDifference1 = array1.Union(array2).ToArray();    //UNION concatenates two sequences into one sequence by removing the duplicate elements
            //int[] arrayDifference2 = array1.Intersect(array2).ToArray(); // INTERSECT ONLY GIVES THE SAME ELEMENTS
            int[] arrayDifference3 = array1.Except(array2).ToArray();    //EXCEPT COMPARES THE 1ST ARRAY WITH 2ND ARRAY AND ONLY SHOWS WHAT IS NOT DIFFERENT IN FIRST ARRAY, OR VICE VERSA.
            int[] arrayDifference4 = array2.Except(array1).ToArray();
            int[] arrayDifference = arrayDifference3.Union(arrayDifference4).ToArray();

            foreach (int num in arrayDifference)
            {
            Console.WriteLine(Convert.ToInt32(num));
            }
        }

    }
}
