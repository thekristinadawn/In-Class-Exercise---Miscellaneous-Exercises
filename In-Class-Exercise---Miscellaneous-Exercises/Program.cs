using System;

namespace In_Class_Exercise___Miscellaneous_Exercises_
{
    internal class Program
    {
        // Exercise 1 - Increasing adjacent numbers
        //static void AdjacentNumbers()
        //{
        //    int sizeArray;
        //    Console.WriteLine("Enter Size of Array:");
        //    sizeArray = Convert.ToInt32(Console.ReadLine());
        //    int[] array = new int[sizeArray1];
        //    Console.WriteLine("Enter numbers:");
        //    for (int i = 0; i < sizeArray; i++)
        //    {
        //        array[i] = Convert.ToInt32(Console.ReadLine());
        //    }

        //    bool threeAdj = false;
        //    for (int i = 0; i < sizeArray - 2; i++)
        //    {
        //        if (array[i] == array[i + 1] - 1 && array[i] == array[i + 2] - 2)

        //        {
        //            threeAdj = true;
        //            Console.WriteLine(threeAdj); ;
        //            break;
        //        }
        //        threeAdj = false;
        //        Console.WriteLine(threeAdj);
        //        break;

        //    }
        //}

        //    static void Main(string[] args)
        //{

        //    AdjacentNumbers();

        //}

        //Exercise 2 : Two-dimensional array
        static void Main(string[] args)
        {
            int[] studentGroup1 = new int[5];
            int sizeGroup1 = 5
            Console.WriteLine("Enter grades for Student Group 1:);
                for (int i = 0; i < sizeGroup1; i++)
            {
                studentGroup1[i] = Convert.ToInt32(Console.ReadLine());
            }
            int[] studentGroup2 = new int[5]
            int sizeGroup2 = 5
            Console.WriteLine("Enter grades for Student Group 2:);
                    for (int i = 0; i < sizeGroup2; i++)
            {
                studentGroup2[i] = Convert.ToInt32(Console.ReadLine());
            }

            
        }

        //Exercise 3 : Difference of arrays
        //static void Main(string[] args)
        //{
        //    int sizeArray1;
        //    Console.WriteLine("Enter Size of Array:");
        //    sizeArray1 = Convert.ToInt32(Console.ReadLine());
        //    int[] array1 = new int[sizeArray1];
        //    Console.WriteLine("Enter numbers:");
        //    for (int i = 0; i < sizeArray1; i++)
        //    {
        //        array1[i] = Convert.ToInt32(Console.ReadLine());
        //    }

        //    int sizeArray2;
        //    Console.WriteLine("Enter Size of Array:");
        //    sizeArray2 = Convert.ToInt32(Console.ReadLine());
        //    int[] array2 = new int[sizeArray2];
        //    Console.WriteLine("Enter numbers:");
        //    for (int i = 0; i < sizeArray2; i++)
        //    {
        //        array2[i] = Convert.ToInt32(Console.ReadLine());
        //    }
        //    var differenceInArrays = array1.Distinct(array2)
        //    Console.WriteLine(String.Join(", ", differenceInArrays));
        }

    }
}
