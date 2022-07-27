using System;

namespace ChapterThree
{
    class Program
    {
        static void Main(string[] args)
        {
            /* 1. Write an expression that checks whether an integer is odd or even.*/
            int oddEven = 7 % 2;
            if(oddEven != 0)
            {
                Console.WriteLine("The integer is odd...");
            }
            Console.WriteLine();

            /* 2. Write a Boolean expression that checks whether a given integer is 
            divisible by both 5 and 7, without a remainder.*/

            Console.WriteLine("Enter any number: ");
            int digit = int.Parse(Console.ReadLine());
            Console.WriteLine($"The number {digit} is divisible by 5 and 7? {(digit % 5 == 0) && (digit % 7 == 0)}");
            Console.WriteLine();

            /* 3. Write an expression that looks for a given integer if its third digit (right 
            to left) is 7.*/

            Console.WriteLine("Enter a number: ");
            int digits = int.Parse(Console.ReadLine());
            int thirdDigit = (digits / 100) % 10;

            if(thirdDigit == 7)
            {
                Console.WriteLine("The third digit to the left is 7.");
                return;
            }
            Console.WriteLine("The third digit to the left isn't 7");
            Console.WriteLine();

            /* 4. Write an expression that checks whether the third bit in a given integer 
            is 1 or 0.*/

            Console.WriteLine("Enter a number to check: ");
            int checkForBit = int.Parse(Console.ReadLine());

            Console.WriteLine($"The third bit in {checkForBit} is: ");
            Console.Write((checkForBit & 8) != 0? 1 : 0);
            Console.WriteLine();

            /* 5. Write an expression that calculates the area of a trapezoid by given 
            sides a, b and height h.*/ 

            Console.Write("Enter side a: ");
            float sideA = float.Parse(Console.ReadLine());
            Console.Write("Enter side b: ");
            float sideB = float.Parse(Console.ReadLine());
            Console.Write("Enter height: ");
            float height = float.Parse(Console.ReadLine());

            double areaOfTrapezoid = (sideA + sideB) * height / 2;
            Console.WriteLine($"The area of a trapezoid with given side {sideA}, {sideB} and {height} is: {areaOfTrapezoid}");
            Console.WriteLine();

            /* 6. Write a program that prints on the console the perimeter and the area 
            of a rectangle by given side and height entered by the user.*/

            Console.Write("Enter side of the rectangle: ");
            float sideOfRectangle = float.Parse(Console.ReadLine());
            Console.Write("Enter height of the rectangle: ");
            float heightOfRectangle = float.Parse(Console.ReadLine());

            float perimeterOfRectangle = (2 * heightOfRectangle) + (2 * sideOfRectangle);
            float areaOfRectangle = heightOfRectangle * sideOfRectangle;

            Console.WriteLine($"The perimeter of a rectangle with given side {sideOfRectangle} and height {heightOfRectangle} is: {perimeterOfRectangle}");
            Console.WriteLine($"The area of a rectangle with given side {sideOfRectangle} and height {heightOfRectangle} is: {areaOfRectangle}");
            Console.WriteLine();

            /* 7. The gravitational field of the Moon is approximately 17% of that on the 
            Earth. Write a program that calculates the weight of a man on the 
            moon by a given weight on the Earth.*/

            Console.Write("Enter chosen weight: ");
            int weight = int.Parse(Console.ReadLine());

            double weightOnMoon = (17d / 100) * weight;
            Console.WriteLine($"The weight of a man on the moon by a given weight of {weight} on the Earth is: {weightOnMoon}");
            Console.WriteLine();

            /* 8. Write an expression that checks for a given point {x, y} if it is within 
            the circle K({0, 0}, R=5). Explanation: the point {0, 0} is the center of 
            the circle and 5 is the radius.
            /* 9. Write an expression that checks for given point {x, y} if it is within the 
            circle K({0, 0}, R=5) and out of the rectangle [{-1, 1}, {5, 5}]. 
            Clarification: for the rectangle the lower left and the upper right corners 
            are given*/

            Console.Write("Enter x: ");
            int pointX = int.Parse(Console.ReadLine());
            Console.Write("Enter y: ");
            int pointY = int.Parse(Console.ReadLine());

            int d = (pointX * pointX) + (pointY * pointY);
            bool isOutsideRectangle = (pointX < -1 && pointX > 5 && pointY < 1 && pointY > 5) ? true : false;

            if(d <= 25)
            {
                Console.Write("The point is inside the circle...");
                return;
            }
            Console.Write("The point is outside the circle...");
            Console.WriteLine("The point O({0},{1}) is outside rectangle ((-1, 1), (5, 5)?: {2}", pointX, pointY, isOutsideRectangle);
            Console.WriteLine();

            /* 10. Write a program that takes as input a four-digit number in format abcd
            (e.g. 2011) and performs the following actions:
            - Calculates the sum of the digits (in our example 2+0+1+1 = 4).
            - Prints on the console the number in reversed order: dcba (in our 
            example 1102).
            - Puts the last digit in the first position: dabc (in our example 1201).
            - Exchanges the second and the third digits: acbd (in our example 
            2101).*/

            Console.Write("Enter a four digit number: ");
            string num = Console.ReadLine();
            int first = int.Parse(num[0].ToString());
            int second = int.Parse(num[1].ToString());
            int third = int.Parse(num[2].ToString());
            int fourth = int.Parse(num[3].ToString());

            Console.WriteLine($"Calculates the sum of the digits: {first + second + third + fourth}");
            Console.WriteLine($"Prints on the console the number in reversed order: {fourth}{third}{second}{first}");
            Console.WriteLine($"Puts the last digit in the first position: {fourth}{first}{second}{third}");
            Console.WriteLine($"Exchanges the second and the third digit: {first}{third}{second}{fourth}");
            Console.WriteLine();

            /* 11. We are given a number n and a position p. Write a sequence of 
            operations that prints the value of the bit on the position p in the 
            number (0 or 1). Example: n=35, p=5 -> 1. Another example: n=35, 
            p=6 -> 0.*/

            Console.Write("Enter any number: ");
            int nNumber = int.Parse(Console.ReadLine());
            Console.Write("Enter position of number: ");
            int pPosition = int.Parse(Console.ReadLine());
            int numShift = 1;
            int valueOfBit = numShift << pPosition;

            Console.Write($"The value of the bit on the position {pPosition} in number {nNumber} is: ");
            Console.Write((nNumber & valueOfBit) != 0 ? 1 : 0);
            Console.WriteLine();

            /* 12. Write a Boolean expression that checks if the bit on position p in the 
            integer v has the value 1. Example v=5, p=1 -> false.*/

            Console.Write("Enter a number: ");
            int integer = int.Parse(Console.ReadLine());
            Console.Write("Enter position of number: ");
            int position = int.Parse(Console.ReadLine());
            int integerNum = 1;
            int bitValue = integerNum << position;
 
            Console.Write($"The bit on position {position} in the integer {integer} has value of 1: ");
            Console.Write((integer & bitValue) == 1 ? true : false); 
            Console.WriteLine();

            /* 13. We are given the number n, the value v (v = 0 or 1) and the position p. 
            write a sequence of operations that changes the value of n, so the bit on 
            the position p has the value of v. Example: n=35, p=5, v=0 -> n=3. 
            Another example: n=35, p=2, v=1 -> n=39.*/

            Console.Write("Enter any number: ");
            int numberEntered = int.Parse(Console.ReadLine());
            Console.Write("Enter either 0 or 1: ");
            int value = int.Parse(Console.ReadLine());
            Console.Write("Enter position: ");
            int posit = int.Parse(Console.ReadLine());
            int positionChange = numberEntered & (~(value << posit)) | (value << posit);
            
            Console.Write(positionChange);
            Console.WriteLine();
            
            /* 14. Write a program that checks if a given number n (1 < n < 100) is a 
            prime number (i.e. it is divisible without remainder only to itself and 1).*/

            int count = 0; int prime, minDivider;

            Console.Write("Enter a number to check if it's prime: ");
            prime = int.Parse(Console.ReadLine());
            minDivider = 2;
            float maxDivider = (float)Math.Sqrt(prime);

            for(int i = 2; i <= prime/minDivider; i++)
            {
                if(prime % i == 0)
                {
                    count = 1;
                    if(count == 2)
                    {
                        Console.Write($"{prime} is not prime...");
                        return;
                    }
                }             
            }
            Console.Write($"{prime} is prime...");
            Console.WriteLine();

            /* 15. Write a program that exchanges the values of the bits on positions 
            3, 4 and 5 with bits on positions 24, 25 and 26 of a given 32-bit unsigned 
            integer.*/

            Console.Write("Enter number: ");
            int val = int.Parse(Console.ReadLine());
            int masked = 1 << 3;
            int bitAt3 = (val & masked) != 0 ? 1 : 0;
            masked = 1 << 4;
            int bitAt4 = (val & masked) != 0 ? 1 : 0;
            masked = 1 << 5;
            int bitAt5 = (val & masked) != 0 ? 1 : 0;
            masked = 1 << 24;
            int bitAt24 = (val & masked) != 0 ? 1 : 0;
            masked = 1 << 25;
            int bitAt25 = (val & masked) != 0 ? 1 : 0;
            masked = 1 << 26;
            int bitAt26 = (val & masked) != 0 ? 1 : 0;

            val = (bitAt3 == 0) ? val = val & (~(1 << 24)) : val = val | (1 << 24);
            val = (bitAt4 == 0) ? val = val & (~(1 << 25)) : val = val | (1 << 25);
            val = (bitAt5 == 0) ? val = val & (~(1 << 26)) : val = val | (1 << 26);
            val = (bitAt24 == 0) ? val = val & (~(1 << 3)) : val = val | (1 << 3);
            val = (bitAt25 == 0) ? val = val & (~(1 << 4)) : val = val | (1 << 4);
            val = (bitAt26 == 0) ? val = val & (~(1 << 5)) : val = val | (1 << 5);

            Console.WriteLine(val);
            Console.WriteLine();

            


        }
    }
}
