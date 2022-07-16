using System;

namespace ChapterThree
{
    class Program
    {
        static void Main(string[] args)
        {
            /* 1. Write an expression that checks whether an integer is odd or even.
            int oddEven = 7 % 2;
            Console.WriteLine(oddEven);
            Console.WriteLine();*/

            /* 2. Write a Boolean expression that checks whether a given integer is 
            divisible by both 5 and 7, without a remainder.

            Console.WriteLine("Enter any number: ");
            int digit = int.Parse(Console.ReadLine());
            Console.WriteLine($"The number {digit} is divisible by 5 and 7? {(digit % 5 == 0) && (digit % 7 == 0)}");*/

            /* 3. Write an expression that looks for a given integer if its third digit (right 
            to left) is 7.

            Console.WriteLine("Enter a number: ");
            int digits = int.Parse(Console.ReadLine());
            int thirdDigit = (digits / 100) % 10;

            if(thirdDigit == 7)
            {
                Console.WriteLine("The third digit to the left is 7.");
            }
            else
            {
                Console.WriteLine("The third digit isn't 7");
            }
            Console.WriteLine();*/

            /* 4. Write an expression that checks whether the third bit in a given integer 
            is 1 or 0.

            Console.WriteLine("Enter a number: ");
            int checkForBit = int.Parse(Console.ReadLine());
            bool bit = (checkForBit & 8) != 0;

            Console.WriteLine(bit);
            Console.WriteLine();*/

            /* 5. Write an expression that calculates the area of a trapezoid by given 
            sides a, b and height h. 

            Console.Write("Enter side a: ");
            float sideA = float.Parse(Console.ReadLine());
            Console.Write("Enter side b: ");
            float sideB = float.Parse(Console.ReadLine());
            Console.Write("Enter height: ");
            float height = float.Parse(Console.ReadLine());

            double areaOfTrapezoid = (sideA + sideB) * height / 2;
            Console.WriteLine($"The area of a trapezoid with given side {sideA}, {sideB} and {height} is: {areaOfTrapezoid}");
            Console.WriteLine();*/

            /* 6. Write a program that prints on the console the perimeter and the area 
            of a rectangle by given side and height entered by the user.

            Console.Write("Enter side of the rectangle: ");
            float sideOfRectangle = float.Parse(Console.ReadLine());
            Console.Write("Enter height of the rectangle: ");
            float heightOfRectangle = float.Parse(Console.ReadLine());

            float perimeterOfRectangle = (2 * heightOfRectangle) + (2 * sideOfRectangle);
            float areaOfRectangle = heightOfRectangle * sideOfRectangle;

            Console.WriteLine($"The perimeter of a rectangle with given side {sideOfRectangle} and height {heightOfRectangle} is: {perimeterOfRectangle}");
            Console.WriteLine($"The area of a rectangle with given side {sideOfRectangle} and height {heightOfRectangle} is: {areaOfRectangle}");
            Console.WriteLine();*/

            /* 7. The gravitational field of the Moon is approximately 17% of that on the 
            Earth. Write a program that calculates the weight of a man on the 
            moon by a given weight on the Earth.

            Console.Write("Enter chosen weight: ");
            int weight = int.Parse(Console.ReadLine());

            double weightOnMoon = (17d / 100) * weight;
            Console.WriteLine($"The weight of a man on the moon by a given weight of {weight} on the Earth is: {weightOnMoon}");
            Console.WriteLine();*/

            /* 8. Write an expression that checks for a given point {x, y} if it is within 
            the circle K({0, 0}, R=5). Explanation: the point {0, 0} is the center of 
            the circle and 5 is the radius.

            Console.Write("Enter x: ");
            float x = float.Parse(Console.ReadLine());
            Console.Write("Enter y: ");
            float y = float.Parse(Console.ReadLine());

            float d = (x * x) + (y * y);

            if(d <= 25)
            {
                Console.Write("The point is inside the circle...");
            }
            else
            {
                Console.Write("The point is outside the circle...");
            }
            Console.WriteLine();*/

            /* 9. Write an expression that checks for given point {x, y} if it is within the 
            circle K({0, 0}, R=5) and out of the rectangle [{-1, 1}, {5, 5}]. 
            Clarification: for the rectangle the lower left and the upper right corners 
            are given*/

            /* 10. Write a program that takes as input a four-digit number in format abcd
            (e.g. 2011) and performs the following actions:
            - Calculates the sum of the digits (in our example 2+0+1+1 = 4).
            - Prints on the console the number in reversed order: dcba (in our 
            example 1102).
            - Puts the last digit in the first position: dabc (in our example 1201).
            - Exchanges the second and the third digits: acbd (in our example 
            2101).

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
            Console.WriteLine();*/

            /* 11. We are given a number n and a position p. Write a sequence of 
            operations that prints the value of the bit on the position p in the 
            number (0 or 1). Example: n=35, p=5 -> 1. Another example: n=35, 
            p=6 -> 0.

            Console.Write("Enter any number: ");
            int n = int.Parse(Console.ReadLine());
            Console.Write("Enter position of number: ");
            int p = int.Parse(Console.ReadLine());
            int num = 1;
            int valueOfBit = num << p;

            Console.Write("The value of the bit on the position " + p + " in number " + n + " is: ");
            Console.Write((n & valueOfBit) != 0 ? 1 : 0);
            Console.WriteLine();*/

            /* 12. Write a Boolean expression that checks if the bit on position p in the 
            integer v has the value 1. Example v=5, p=1 -> false.

            Console.Write("Enter a number: ");
            int integer = int.Parse(Console.ReadLine());
            Console.Write("Enter position of number: ");
            int position = int.Parse(Console.ReadLine());
            int integerNum = 1;
            int bitValue = integerNum << position;
 
            if(bitValue == 1)
            {
            Console.Write($"The bit on position {position} in the integer {integer} has value of 1: ");
            Console.Write((integer & bitValue) == 1 ? true : false); 
            }
            else
            {
                Console.Write($"The bit on position {position} in the integer {integer} has value of 1: ");
                Console.Write((integer & bitValue) == 1 ? true : false);
            }
            Console.WriteLine();*/

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
            n = n & (~(1 << p));
            You can reset the bit at position p in the number n as follows:
You can set bits in the unit at position p in the number n as follows:
n = n | (1 << p);




        
            
        }
    }
}
