using System;

namespace ChapterFive
{
    class Program
    {
        static void Main(string[] args)
        {
            /* 1. Write an if-statement that takes two integer variables and exchanges
            their values if the first one is greater than the second one.*/

            Console.WriteLine("Enter two numbers: ");
            int firstVariable = int.Parse(Console.ReadLine());
            int secondVariable = int.Parse(Console.ReadLine());

            if(firstVariable > secondVariable)
            {
                firstVariable = secondVariable;
            }
            Console.WriteLine(secondVariable);
            Console.WriteLine();

            /* 2. Write a program that shows the sign (+ or -) of the product of three real 
            numbers, without calculating it. Use a sequence of if operators.*/

            /*3. Write a program that finds the biggest of three integers, using nested 
            if statements.*/

            Console.WriteLine("Enter three numbers: ");
            int bigNum = int.Parse(Console.ReadLine());
            int bigNumber = int.Parse(Console.ReadLine());
            int biggerNum = int.Parse(Console.ReadLine());

            if(bigNum > bigNumber && bigNum > biggerNum)
            {
                Console.WriteLine($"{bigNum} is the biggest of the given numbers");
            }
            else if (bigNumber > bigNum && bigNumber > biggerNum)
            {
                Console.WriteLine($"{bigNumber} is the biggest of the given numbers");
                return;
            }
            
            Console.WriteLine($"{biggerNum} is the biggest of the given numbers");
            Console.WriteLine();

            /* 4. Sort 3 real numbers in descending order. Use nested if statements.*/

            Console.WriteLine("Enter three numbers: ");
            int firstRealNum = int.Parse(Console.ReadLine());
            int secondRealNum = int.Parse(Console.ReadLine());
            int thirdRealNum = int.Parse(Console.ReadLine());

            if(firstRealNum < secondRealNum && firstRealNum < thirdRealNum)
            {
                Console.WriteLine($"{firstRealNum} {secondRealNum} {thirdRealNum} ");
            }
            else if (secondRealNum < firstRealNum && secondRealNum < thirdRealNum)
            {
                Console.WriteLine($"{secondRealNum} {firstRealNum} {thirdRealNum} ");
            }
            else 
            {
                Console.WriteLine($"{thirdRealNum} {firstRealNum} {secondRealNum} ");
            }
            Console.WriteLine(); 

            /* 5. Write a program that asks for a digit (0-9), and depending on the input, 
            shows the digit as a word (in English). Use a switch statement.*/

            Console.Write("Enter a digit between 0 - 9: ");
            int digit = int.Parse(Console.ReadLine());

            switch(digit)
            {
                case 0:
                Console.WriteLine("Zero");
                break;
                case 1:
                Console.WriteLine("One");
                break;
                case 2:
                Console.WriteLine("Two");
                break;
                case 3:
                Console.WriteLine("Three");
                break;
                case 4:
                Console.WriteLine("Four");
                break;
                case 5:
                Console.WriteLine("Five");
                break;
                case 6:
                Console.WriteLine("Six");
                break;
                case 7:
                Console.WriteLine("Seven");
                break;
                case 8:
                Console.WriteLine("Eight");
                break;
                case 9:
                Console.WriteLine("Nine");
                break;
                default:
                Console.WriteLine("Invalid input!!!");
                break;
            }
            Console.WriteLine(); 

            /* 6. Write a program that gets the coefficients a, b and c of a quadratic 
            equation: ax2 + bx + c, calculates and prints its real roots (if they exist). 
            Quadratic equations may have 0, 1 or 2 real roots.*/

            Console.Write("Enter coefficient a: ");
            double a = double.Parse(Console.ReadLine());
            Console.Write("Enter coefficient b: ");
            double b = double.Parse(Console.ReadLine());
            Console.Write("Enter coefficient c: ");
            double c = double.Parse(Console.ReadLine());

            double discriminant = (b * b ) - (4 * a * c);
            if (discriminant == 0)
            {
                double oneRoot = -b / (2 * a);
                Console.WriteLine(oneRoot);
            }
           Console.WriteLine();

            /* 7. Write a program that finds the greatest of given 5 numbers.*/

            Console.WriteLine("Enter five numbers: ");
            int numOne = int.Parse(Console.ReadLine());
            int numTwo = int.Parse(Console.ReadLine());
            int numThree = int.Parse(Console.ReadLine());
            int numFour = int.Parse(Console.ReadLine());
            int numFive = int.Parse(Console.ReadLine());

            if(numOne > numTwo && numOne > numThree && numOne > numFour && numOne > numFive)
            {
                Console.WriteLine($"The greatest of {numOne}, {numTwo}, {numThree}, {numFour} and {numFive} is: {numOne}");
            }
            else if(numTwo > numOne && numTwo > numThree && numTwo > numFour && numTwo > numFive)
            {
                Console.WriteLine($"The greatest of {numOne}, {numTwo}, {numThree}, {numFour} and {numFive} is: {numTwo}");
            }
            else if (numThree > numOne && numThree > numTwo && numThree > numFour && numThree > numFive)
            {
                Console.WriteLine($"The greatest of {numOne}, {numTwo}, {numThree}, {numFour} and {numFive} is: {numThree}");
            }
            else if(numFour > numOne && numFour > numTwo && numFour > numThree && numFour > numFive)
            {
                Console.WriteLine($"The greatest of {numOne}, {numTwo}, {numThree}, {numFour} and {numFive} is: {numFour}");
            }
            else
            {
                Console.WriteLine($"The greatest of {numOne}, {numTwo}, {numThree}, {numFour} and {numFive} is: {numFive}");
            }
            Console.WriteLine(); 

            /* 8. Write a program that, depending on the user’s choice, inputs int, double
            or string variable. If the variable is int or double, the program 
            increases it by 1. If the variable is a string, the program appends "*" at 
            the end. Print the result at the console. Use switch statement.*/

            Console.Write("Enter an element: ");
            int variable = int.Parse(Console.ReadLine());

            switch (variable)
            {
                case 0:
                    {
                        Console.Write("Enter int variable: ");
                        variable = int.Parse(Console.ReadLine());
                        variable++;
                        Console.WriteLine($"Int variable + 1 = {variable}");
                        break;
                    }
                case 1:
                    {
                        Console.Write("Enter double variable: ");
                        double doubleVar = double.Parse(Console.ReadLine());
                        doubleVar++;
                        Console.WriteLine($"Double variable + 1 = {doubleVar}");
                        break;
                    }
                case 2:
                    {
                        Console.Write("Enter string variable: ");
                        string stringVar = Console.ReadLine();
                        stringVar = stringVar + '*';
                        Console.WriteLine($"String variable +* = {stringVar}");
                        break;
                    }
                default: 
                Console.WriteLine("Wrong input"); 
                break;
            }
            Console.WriteLine(); 

            /* 9. We are given 5 integer numbers. Write a program that finds those 
            subsets whose sum is 0. Examples:
            - If we are given the numbers {3, -2, 1, 1, 8}, the sum of -2, 1 and 1 
            is 0.
            - If we are given the numbers {3, 1, -7, 35, 22}, there are no subsets 
            with sum 0.*/   

            /* 10. Write a program that applies bonus points to given scores in the range 
            [1…9] by the following rules:
            - If the score is between 1 and 3, the program multiplies it by 10.
            - If the score is between 4 and 6, the program multiplies it by 100.
            - If the score is between 7 and 9, the program multiplies it by 1000.
            - If the score is 0 or more than 9, the program prints an error 
            message.*/    

            Console.Write("Enter a score within the range of 1 - 9: ");  
            int score = int.Parse(Console.ReadLine());

            switch(score)
            {
                case 1:
                case 2: 
                case 3:
                Console.WriteLine(score * 10);
                break;
                case 4:
                case 5:
                case 6:
                Console.WriteLine(score * 100);
                break;
                case 7:
                case 8:
                case 9:
                Console.WriteLine(score * 1000);
                break;
                default:
                Console.WriteLine("Error!!!");
                break;
            }
            Console.WriteLine(); 

            /* 11. Write a program that converts a number in the range [0…999] to 
            words, corresponding to the English pronunciation. Examples:
            - 0 --> "Zero"
            - 12 --> "Twelve"
            - 98 --> "Ninety eight"
            - 273 --> "Two hundred seventy three"
            - 400 --> "Four hundred"
            - 501 --> "Five hundred and one"
            - 711 --> "Seven hundred and eleven"*/
        }
    }

} 
