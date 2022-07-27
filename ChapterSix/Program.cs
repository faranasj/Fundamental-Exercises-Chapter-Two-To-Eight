using System;

namespace ChapterSix
{
    class Program
    {
        static void Main(string[] args)
        {
            /* 1. Write a program that prints on the console the numbers from 1 to N. 
            The number N should be read from the standard input.*/

            Console.Write("Enter any number: ");
            int anyNumber = int.Parse(Console.ReadLine());

            for(int a = 1; a <= anyNumber; a++)
            {
                Console.Write($"{a} ");
            }
            Console.WriteLine();

            /*2. Write a program that prints on the console the numbers from 1 to N, 
            which are not divisible by 3 and 7 simultaneously. The number N 
            should be read from the standard input.*/

            Console.Write("Enter a number: ");
            int numberNotDivisible = int.Parse(Console.ReadLine());

            for(int b = 0; b < numberNotDivisible; b++)
                {
                    if(b % (3 * 7) != 0)
                    {
                        Console.Write($"{b} ");
                    }
                }
            Console.WriteLine(); 

            /*3. Write a program that reads from the console a series of integers and 
            prints the smallest and largest of them.*/

            int smallest = 0, largest = 0, input, countOfNum;

            Console.WriteLine("Enter count of number: ");
            countOfNum = int.Parse(Console.ReadLine());

            for(int c = 0; c < countOfNum; c++)
            {
                Console.Write("Enter numbers: ");
                input = int.Parse(Console.ReadLine());

                if(c == 0)
                {
                    smallest = largest = input;
                }
                else if(smallest > input)
                {
                    smallest = input;
                }
                else if(largest < input)
                {
                    largest = input;
                }
            }
            Console.Write($"{smallest} is the smallest and {largest} is the largest of the given numbers.");
            Console.WriteLine();

            /* 4. Write a program that prints all possible cards from a standard deck
            of cards, without jokers (there are 52 cards: 4 suits of 13 cards).*/

            for(int card = 1; card <= 13; card++)
                {
                    for(int suit = 1; suit <= 4; suit++)
                    {
                        switch(suit)
                        {
                            case 1:
                            Console.Write("Club ");
                            break;
                            case 2:
                            Console.Write("Diamond ");
                            break;
                            case 3:
                            Console.Write("Heart ");
                            break;
                            case 4:
                            Console.Write("Spades ");
                            break;
                        }
                    }

                    switch(card)
                    {
                        case 1:
                        Console.WriteLine("2");
                        break;
                        case 2:
                        Console.WriteLine("3");
                        break;
                        case 3:
                        Console.WriteLine("4");
                        break;
                        case 4:
                        Console.WriteLine("5");
                        break;
                        case 5:
                        Console.WriteLine("6");
                        break;
                        case 6:
                        Console.WriteLine("7");
                        break;
                        case 7:
                        Console.WriteLine("8");
                        break;
                        case 8:
                        Console.WriteLine("9");
                        break;
                        case 9:
                        Console.WriteLine("10");
                        break;
                        case 10:
                        Console.WriteLine("J");
                        break;
                        case 11: 
                        Console.WriteLine("Q");
                        break;
                        case 12:
                        Console.WriteLine("K");
                        break;
                        case 13:
                        Console.WriteLine("A");
                        break;
                    }
                }
                Console.WriteLine();

            /* 5. Write a program that reads from the console number N and print the sum 
            of the first N members of the Fibonacci sequence: 0, 1, 1, 2, 3, 5, 8, 
            13, 21, 34, 55, 89, 144, 233, 377, …*/

            int firstFibNum = 0, secondFibNum = 1, thirdFibNum = 0, fibNum, sum = 0;

            Console.Write("Enter N members of the Fibonacci sequence: ");
            fibNum = int.Parse(Console.ReadLine());
            Console.Write($"{firstFibNum} {secondFibNum} ");

            for(int d = 2; d <= fibNum; d++)
            {
                thirdFibNum = firstFibNum + secondFibNum;
                Console.Write($"{thirdFibNum} ");
                firstFibNum = secondFibNum;
                secondFibNum = thirdFibNum;
                sum += d;
            }
            Console.Write($"The sum of the first N members of the Fibonacci sequence from 1 to {fibNum} is {sum}");
            Console.WriteLine(); 

            /* 6. Write a program that calculates N!/K! for given N and K (1<K<N).*/
            
            Console.WriteLine("Enter n: ");
            int factorialOfN = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter k: ");
            int factorialOfK = int.Parse(Console.ReadLine());
            int e = factorialOfN - 1, f = factorialOfK - 1;

            while(e > 0)
            {
                factorialOfN *= e;
                e--;
            }
            while(f > 0)
            {
                factorialOfK *= f;
                f--;
            }
            factorialOfN /= factorialOfK;
            
            Console.Write($"The result is {factorialOfN}");
            Console.WriteLine(); 

            /* 7. Write a program that calculates N!*K!/(N-K)! for given N and K 
            (1<K<N).*/

            Console.WriteLine("Enter n: ");
            int factorOfN = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter k: ");
            int factorOfK = int.Parse(Console.ReadLine());
            int factorNMinusK = factorOfN - factorOfK;
            int calculation;

            for(int g = factorOfN - 1; g > 0; g--)
            {
                factorOfN *= g;
            }
            for(int h = factorOfK - 1; h > 0; h--)
            {
                factorOfK *= h;
            }
            for(int i = factorNMinusK - 1; i > 0; i--)
            {
                factorNMinusK *= i;
            }
            calculation = (factorOfN * factorOfK) / factorNMinusK;
            Console.Write($"The result is {calculation}");
            Console.WriteLine(); 

            /* 8. Write a program that calculates the nth Catalan number by given n.*/

            Console.WriteLine("Enter n: ");
            int catalanNum = int.Parse(Console.ReadLine());
            int catalanNumMultiple = 2 * catalanNum, catalanNumSum = catalanNum + 1;

            for(int j = catalanNumMultiple - 1; j > 0; j--)
            {
                catalanNumMultiple *= j;
            }
            for(int k = catalanNumSum - 1; k > 0; k--)
            {
                catalanNumSum *= k;
            }
            for(int l = catalanNum - 1; l > 0; l--)
            {
                catalanNum *= l;
            }
            catalanNum = catalanNumMultiple / (catalanNumSum * catalanNum);
            Console.Write($"The result is {catalanNum}");
            Console.WriteLine(); 

            /* 9. Write a program that for a given integers n and x, calculates the sum*/ 

            Console.WriteLine("Enter n: ");
            int factorN = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter x: ");
            int factorX = int.Parse(Console.ReadLine());
            int factorNAndX = 1, sumOf = 1;

            for(int m = 1; m <= factorN; m++)
            {
                factorNAndX *= (m / factorX);
                sumOf += factorNAndX;
            }
            Console.Write($"The result is {sum}");
            Console.WriteLine(); 

            /* 10. Write a program that reads from the console a positive integer number 
            N (N < 20) and prints a matrix of numbers.
            You should use two nested loops, similar to the problem "Printing a 
            Triangle". The outer loop must run from 1 to N, and the inner – from the 
            value of the outer loop to the value of the outer loop + N - 1.*/

            Console.WriteLine("Enter any number between 2 and 20: ");
            int matrixN = int.Parse(Console.ReadLine());

            for(int n = 1; n <= matrixN; n++)
            {
                for(int o = n; o <= n + matrixN - 1; o++)
                {
                    Console.Write(o + " ");
                }
            }
            Console.WriteLine(); 
            
            /* 11. Write a program that calculates with how many zeroes the factorial of 
            a given number ends.*/

            Console.Write("Enter a number: ");
            ulong factorialNum = ulong.Parse(Console.ReadLine());
            int zero = 0;

            for(ulong p = factorialNum - 1; p > 0; p--)
            {
                factorialNum *= p;
            }
            Console.WriteLine($"The factorial of {factorialNum} ends with ");
            
            do
            {
                factorialNum /= 10;
                zero++;
            } while (factorialNum % 10 == 0);
            Console.Write($"{zero} zeroes.");
            Console.WriteLine(); 

            /* 12. Write a program that converts a given number from decimal to binary 
            notation (numeral system).*/

            Console.WriteLine("Enter decimal number to convert to binary: ");
            int decimalNum = int.Parse(Console.ReadLine());
            string binaryNum = Convert.ToString(decimalNum, 2);

            Console.WriteLine($"Binary form of {decimalNum} is: {binaryNum}");
            Console.WriteLine(); 

            /* 13. Write a program that converts a given number from binary to decimal 
            notation.*/

            Console.WriteLine("Enter binary number to convert to decimal: ");
            string numBinary = Console.ReadLine();
            int numDecimal = Convert.ToInt32(numBinary, 2);

            Console.WriteLine($"Decimal form of {numBinary} is: {numDecimal}");
            Console.WriteLine(); 

            /* 14. Write a program that converts a given number from decimal to 
            hexadecimal notation.*/

            Console.WriteLine("Enter decimal number to convert to hexadecimal: ");
            int dexNum  = int.Parse(Console.ReadLine());
            string hexNum = dexNum.ToString("X");

            Console.WriteLine($"Hexadecimal form of {dexNum} is: {hexNum}");
            Console.WriteLine(); 

            /* 15. Write a program that converts a given number from hexadecimal to 
            decimal notation.*/

            Console.WriteLine("Enter hexadecimal number to convert to decimal: ");
            string hexaNum = Console.ReadLine();
            int decimalNumber = Convert.ToInt32(hexaNum, 16);

            Console.WriteLine($"Decimal form of {hexaNum} is: {decimalNumber}");
            Console.WriteLine(); 

            /* 16. Write a program that by a given integer N prints the numbers from 1 to N 
            in random order.*/

            /* 17. Write a program that given two numbers finds their greatest common 
            divisor (GCD) and their least common multiple (LCM). You may use 
            the formula LCM(a, b) = |a*b| / GCD(a, b).*/

            /* 18. Write a program that for a given number n, outputs a matrix in the 
            form of a spiral*/
        }

        
    }
}
