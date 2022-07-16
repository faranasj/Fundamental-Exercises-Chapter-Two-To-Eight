using System;

namespace ChapterFour
{
    class Program
    {
        static void Main(string[] args)
        {
            /* 1. Write a program that reads from the console three numbers of type int
            and prints their sum.

            Console.WriteLine("Enter three numbers: ");
            int firstNumber = int.Parse(Console.ReadLine());
            int secondNumber = int.Parse(Console.ReadLine());
            int thirdNumber = int.Parse(Console.ReadLine());

            int sumOfThreeNumbers = firstNumber + secondNumber + thirdNumber;

            Console.WriteLine($"The sum of {firstNumber}, {secondNumber} and {thirdNumber} is: {sumOfThreeNumbers}");
            Console.WriteLine();*/

            /* 2. Write a program that reads from the console the radius "r" of a circle 
            and prints its perimeter and area.*

            Console.WriteLine("Enter radius of a circle: ");
            int radius = int.Parse(Console.ReadLine());

            double perimeter = 2 * Math.PI * radius;
            double area = Math.PI * radius * radius;
            double perimeterRound = Math.Round(perimeter, 2);
            double areaRound = Math.Round(area, 2);
            
            Console.WriteLine($"The perimeter and area of a circle with radius {radius} is: {perimeterRound} and {areaRound}.");
            Console.WriteLine();*/

            /* 3. A given company has name, address, phone number, fax number, web 
            site and manager. The manager has name, surname and phone number.
            Write a program that reads information about the company and its 
            manager and then prints it on the console.

            Console.Write("Enter company name: ");
            string comapanyName = Console.ReadLine();
            Console.Write("Enter company address: ");
            string comapanyAddress = Console.ReadLine();
            Console.Write("Enter company phone number: ");
            double comapanyPhoneNo = double.Parse(Console.ReadLine());
            Console.Write("Enter company fax number: ");
            int comapanyFaxNo = int.Parse(Console.ReadLine());
            Console.Write("Enter company website: ");
            string comapanyWebsite = Console.ReadLine();
            Console.Write("Enter manager firstname: ");
            string managerFirstName = Console.ReadLine();
            Console.Write("Enter manager lastname: ");
            string managerLastName = Console.ReadLine();
            Console.Write("Enter manager phone number: ");
            double managerPhoneNo = double.Parse(Console.ReadLine());

            Console.Write("{0} is a telecommunication company located at {1} with phone number {2}, fax number {3}\n and website address {4}. The top manager is {5} {6} and he can be contacted at {7}.", comapanyName, comapanyAddress, comapanyPhoneNo, comapanyFaxNo, comapanyWebsite, managerFirstName, managerLastName, managerPhoneNo);*/

            /* 4. Write a program that prints three numbers in three virtual columns
            on the console. Each column should have a width of 10 characters and 
            the numbers should be left aligned. The first number should be an 
            integer in hexadecimal; the second should be fractional positive; and 
            the third – a negative fraction. The last two numbers have to be 
            rounded to the second decimal place.

            int hexNum = 3457;
            float fracNum = (float)3458.7893;
            float negativeFraction = (float)-2345.8765;

            Console.WriteLine("[{0, -10:X}]", hexNum);
            Console.WriteLine("[{0, -10:F2}]", fracNum);
            Console.WriteLine("[{0, -10:F2}]", negativeFraction);*/

            /* 5. Write a program that reads from the console two integer numbers (int)
            and prints how many numbers between them exist, such that the 
            remainder of their division by 5 is 0. Example: in the range (14, 25) 
            there are 3 such numbers: 15, 20 and 25. 

            Console.WriteLine("Enter minimum and maximum number: ");
            int minNumber = int.Parse(Console.ReadLine());
            int maxNumber = int.Parse(Console.ReadLine());

            Console.WriteLine($"The numbers divisible by 5 without remainder from {minNumber} to {maxNumber} are: ");

            for(int i = minNumber; i <= maxNumber; i++)
            {
                if(i % 5 == 0)
                {
                    Console.Write($"{i}, ");                 
                }
            }
            Console.WriteLine();*/

            /* 6. Write a program that reads two numbers from the console and prints the 
            greater of them. Solve the problem without using conditional 
            statements.

            Console.Write("Enter first number: ");
            int firstNumero = int.Parse(Console.ReadLine());
            Console.Write("Enter second number: ");
            int secondNumero = int.Parse(Console.ReadLine());
            int greaterNumber = Math.Max(firstNumero, secondNumero);

            Console.WriteLine($"The greater number between {firstNumero} and {secondNumero} is: {greaterNumber} ");
            Console.WriteLine();*/

            /* 7. Write a program that reads five integer numbers and prints their 
            sum. If an invalid number is entered the program should prompt the user 
            to enter another number.

            int sum = 0;
            int i = 0;
            while (i <= 4)
            {
                Console.Write("Enter five numbers: ");
                string input = Console.ReadLine();
                int a;
                bool parseSuccess = int.TryParse(input, out a);

                if (!parseSuccess)
                {
                    i--;
                    Console.Write("Invalid input!");
                }

                sum +=a;
                i++;
            }
            Console.WriteLine($"The sum of the numbers is: {sum}");
            Console.WriteLine();*/

            /* 8. Write a program that reads five numbers from the console and prints the 
            greatest of them.

            Console.WriteLine("Kindly enter 5 numbers: ");
            int firstNum = Int32.Parse(Console.ReadLine());
            int secondNum = Int32.Parse(Console.ReadLine());
            int thirdNum = Int32.Parse(Console.ReadLine());
            int fourthNum = Int32.Parse(Console.ReadLine());
            int fifthNum = Int32.Parse(Console.ReadLine());

            if((firstNum >= secondNum) && (firstNum >= thirdNum) && (firstNum >= fourthNum) && (firstNum >= fifthNum))
            {
                Console.WriteLine($"The greatest number is: {firstNum}");
            }
            else if((secondNum >= firstNum) && (secondNum >= thirdNum) && (secondNum >= fourthNum) && (secondNum >= fifthNum))
            {
                Console.WriteLine($"The greatest number is: {secondNum}");
            }
            else if((thirdNum >= firstNum) && (thirdNum >= secondNum) && (thirdNum >= fourthNum) && (thirdNum >= fifthNum))
            {
                Console.WriteLine($"The greatest number is: {thirdNum}");
            }
            else if((fourthNum >= firstNum) && (fourthNum >= secondNum) && (fourthNum >= thirdNum) && (fourthNum >= fifthNum))
            {
                Console.WriteLine($"The greatest number is: {fourthNum}");
            }
            else if((fifthNum >= firstNum) && (fifthNum >= secondNum) && (fifthNum >= thirdNum) && (fifthNum >= fourthNum))
            {
                Console.WriteLine($"The greatest number is: {fifthNum}");
            }
            Console.WriteLine();*/

            /* 9. Write a program that reads an integer number n from the console. After 
            that reads n numbers from the console and prints their sum.

            Console.WriteLine("Enter number of times: ");
            int numberOfTimes = int.Parse(Console.ReadLine());
            int sum = 0;
            
            for(int i = 1; i <= numberOfTimes; i++)
            {
                Console.WriteLine("Enter number: ");
                int anyNumber = int.Parse(Console.ReadLine());

                sum += anyNumber;
            }
            Console.Write($"The sum of all the numbers are: {sum}");
            Console.WriteLine();*/

            /* 10. Write a program that reads an integer number n from the console and 
            prints all numbers in the range [1…n], each on a separate line.

            Console.WriteLine("Enter n number: ");
            int nNumber = int.Parse(Console.ReadLine());
            int fixedNumber = 1;

            for(int i = fixedNumber; i <= nNumber; i++)
            {
                Console.WriteLine(i);
            }
            Console.WriteLine();*/

            /* 11. Write a program that prints on the console the first 100 numbers in the 
            Fibonacci sequence: 0, 1, 1, 2, 3, 5, 8, 13, 21, 34, 55, 89, 144, 233, …

            uint firstHundred = 0;
            uint firstHundredFib = 1;
            Console.Write($"The first hundred Fibonacci sequence are: {firstHundred}, {firstHundredFib}, ");

            for(int i = 2; i <= 100; i++)
            {
                uint firstHundredFibonacci = firstHundred + firstHundredFib;
                Console.Write($"{firstHundredFibonacci}, ");
                firstHundred = firstHundredFib;
                firstHundredFib = firstHundredFibonacci;
            }
            Console.WriteLine();*/

            /* 12. Write a program that calculates the sum (with precision of 0.001) of 
            the following sequence: 1 + 1/2 - 1/3 + 1/4 - 1/5 + …*/
        }
    }
}
