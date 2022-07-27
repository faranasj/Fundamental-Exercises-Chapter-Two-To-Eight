using System;

namespace ChapterSeven
{
    class Program
    {
        static void Main(string[] args)
        {
            /* 1. Write a program, which creates an array of 20 elements of type 
            integer and initializes each of the elements with a value equals to the 
            index of the element multiplied by 5. Print the elements to the console.*/
            
            int[] arrElement = new int [20];
            for(int a = 0; a < arrElement.Length - 1; a++)
            {
                arrElement[a] = a;
                arrElement[a] = arrElement[a] * 5;
                Console.Write($"{arrElement[a]} ");
            }
            Console.WriteLine();

            /* 2. Write a program, which reads two arrays from the console and checks 
            whether they are equal (two arrays are equal when they are of equal 
            length and all of their elements, which have the same index, are equal).*/

            Console.Write("Enter length of first array: ");
            int firstArr = int.Parse(Console.ReadLine());
            int[] arrFirst = new int [firstArr];
            bool isEqual = true;
            int b, c;

            for(b = 0; b < arrFirst.Length - 1; b++)
            {
                arrFirst[b] = b;
                Console. Write("Enter elements of first array: ");
                arrFirst[b] =int.Parse(Console.ReadLine());
            }

            Console.Write("Enter length of second array: ");
            int secondArr = int.Parse(Console.ReadLine());
            int[] arrSecond = new int [secondArr];

            for(c = 0; c < arrSecond.Length - 1; c++)
            {
                arrSecond[c] = c;
                Console. Write("Enter elements of second array: ");
                arrSecond[c] = int.Parse(Console.ReadLine());
            }

            if(arrFirst[b] == arrSecond[c])
            {
                Console.Write($"{arrFirst[b]} and {arrSecond[c]} is equal: {isEqual}");
                return;
            }
            Console.Write($"{arrFirst[b]} and {arrSecond[c]} are not equal.");
            Console.WriteLine();

            /* 4. Write a program, which finds the maximal sequence of consecutive 
            equal elements in an array. E.g.: {1, 1, 2, 3, 2, 2, 2, 1}  {2, 2, 2}.*/

            int arrlength = 1, tempLengt = 1, number = 0, t, begin;
            Console.Write("Enter length of array: ");
            int maximal = int.Parse(Console.ReadLine());
            int[] arrMaximal = new int [maximal];

            for(t = 0; t < arrMaximal.Length - 1; t++)
            {
                arrMaximal[t] = t;
                Console.Write("Enter elements of array: ");
                arrMaximal[t] = int.Parse(Console.ReadLine());
            }

            for(begin = 0; begin < arrMaximal.Length - 1; begin++)
            {
                if(arrMaximal[t] % arrMaximal[t - 1] == 0)
                {
                    tempLengt++;
                    return;
                }
                tempLengt = 1;

                if(tempLengt > arrlength)
                {
                    arrlength = tempLengt;
                    arrMaximal[t] = number;
                }
            }
            for(t = 0; t < arrlength; t++)
            {
                Console.Write(number);
            }
            Console.WriteLine();

            /* 8. Sorting an array means to arrange its elements in an increasing (or 
            decreasing) order. Write a program, which sorts an array using the 
            algorithm "selection sort".*/

            int i, j, min, temp;

            Console.Write("Enter array length: ");
            int length = Int32.Parse(Console.ReadLine());

            int[] aray = new int[length];

            for (i = 0; i < length; i++)
            {
                Console.Write($"Enter {i} element: ");
                aray[i] = Int32.Parse(Console.ReadLine());
            }

            for (j = 0; j < length - 1; j++)
            {
                min = j;
                
                for (i = j + 1; i < length; i++) 
                {
                    if (aray[i] < aray[min]) 
                    {
                        min = i;
                    }
                }

                if (min != j)
                {
                    temp = aray[j];
                    aray[j] = aray[min];
                    aray[min] = temp;
                }
            }

            for (i = 0; i < length; i++) 
            {
                Console.Write("{0} ", aray[i]);
            }
            Console.WriteLine();

            /* 11. Write a program to find a sequence of neighbor numbers in an array, 
            which has a sum of certain number S. Example: {4, 3, 1, 4, 2, 5, 8},
            S=11  {4, 2, 5}.*/

            int sum = 0, start = 0, end = 0;
            bool sumGotten = false;

            Console.WriteLine("Enter S: ");
            int numberS = int.Parse(Console.ReadLine());

            Console.Write("Enter array length: ");
            int arLength = int.Parse(Console.ReadLine());

            int[] arr = new int[arLength];
                        
            for (int e = 0; e < arLength; e++)
            {
                Console.Write($"Enter {e} element: ");
                arr[e] = int.Parse(Console.ReadLine());
            }
            
            for (int e = 0; e < arLength - 1; e++)
            {
                sum = arr[e];

                for (int f = e + 1; f < arLength; f++)
                {
                    sum += arr[f];
                    if (sum == numberS)
                    {
                        start = e;
                        end = f;
                        sumGotten = true;
                        break;
                    }
                }

                if (sumGotten) break;
            }

            if (sumGotten) 
            {
                for (int e = start; e <= end; e++) 
                {
                    Console.Write($"{arr[e]},");
                }
            }
            else 
            {
                Console.WriteLine("No sum found.");
            }
            Console.WriteLine();
            
        }
    }
}
