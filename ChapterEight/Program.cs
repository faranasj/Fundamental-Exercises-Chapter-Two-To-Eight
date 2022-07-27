using System;

namespace ChapterEight
{
    class Program
    {
        static void Main(string[] args)
        {
            /* 1. Convert the numbers 151, 35, 43, 251, 1023 and 1024 to the binary 
            numeral system.*/
           
            int firstDexNum = 151, secondDexNum = 35, thirdDexNum = 43, fourthDexNum = 251, fifthDexNum = 1023, sixthDexNum = 1024;
            string firstBinaryNum = Convert.ToString(firstDexNum, 2);
            string secondBinaryNum = Convert.ToString(secondDexNum, 2);
            string thirdBinaryNum = Convert.ToString(thirdDexNum, 2);
            string fourthBinaryNum = Convert.ToString(fourthDexNum, 2);
            string fifthBinaryNum = Convert.ToString(fifthDexNum, 2);
            string sixthBinaryNum = Convert.ToString(sixthDexNum, 2);

            Console.Write($"The binary form of {firstDexNum}, {secondDexNum}, {thirdDexNum}, {fourthDexNum}, {fifthDexNum} and {sixthDexNum} is: {firstBinaryNum} {secondBinaryNum} {thirdBinaryNum} {fourthBinaryNum} {fifthBinaryNum} {sixthBinaryNum}");
            Console.WriteLine();

            /* 2. Convert the number 1111010110011110(2) to hexadecimal and decimal
            numeral systems.*/

            string binaryNumber = "1111010110011110";
            int numDex = Convert.ToInt32(binaryNumber, 2);
            string hexadecimalNumber = numDex.ToString("X");

            Console.WriteLine($"Hexadecimal form of {binaryNumber} is: {hexadecimalNumber}");
            Console.WriteLine($"Decimal form of {binaryNumber} is: {numDex}");
            Console.WriteLine(); 

            /* 3. Convert the hexadecimal numbers FA, 2A3E, FFFF, 5A0E9 to binary and 
            decimal numeral systems.*/

            string firstHexNum = "FA", secondHexNum = "2A3E", thirdHexNum = "FFFF", fourthHexNum = "5A0E9";
            int firstNumDex = Convert.ToInt32(firstHexNum, 16);
            int secondNumDex = Convert.ToInt32(secondHexNum, 16);
            int thirdNumDex = Convert.ToInt32(thirdHexNum, 16);
            int fourthNumDex = Convert.ToInt32(fourthHexNum, 16);
            string firstBinaNum = Convert.ToString(firstNumDex, 2);
            string secondBinaNum = Convert.ToString(secondNumDex, 2);
            string thirdBinaNum = Convert.ToString(thirdNumDex, 2);
            string fourthBinaNum = Convert.ToString(fourthNumDex, 2);

            Console.WriteLine($"Binary form of {firstHexNum} is: {firstBinaNum} and its decimal form is {firstNumDex}");
            Console.WriteLine($"Binary form of {secondHexNum} is: {secondBinaNum} and its decimal form is {secondNumDex}");
            Console.WriteLine($"Binary form of {thirdHexNum} is: {thirdBinaNum} and its decimal form is {thirdNumDex}");
            Console.WriteLine($"Binary form of {fourthHexNum} is: {fourthBinaNum} and its decimal form is {fourthNumDex}");
            Console.WriteLine(); 

            /* 4. Write a program that converts a decimal number to binary one.*/

            Console.WriteLine("Enter decimal number to convert to binary: ");
            int dexNum = int.Parse(Console.ReadLine());
            string binaryNum = Convert.ToString(dexNum, 2);

            Console.WriteLine($"Binary form of {dexNum} is: {binaryNum}");
            Console.WriteLine(); 

            /* 5. Write a program that converts a binary number to decimal one.*/

            Console.WriteLine("Enter binary number to convert to decimal: ");
            string numBinary = Console.ReadLine();
            int numDex = Convert.ToInt32(numBinary, 2);

            Console.WriteLine($"Decimal form of {numBinary} is: {numDex}");
            Console.WriteLine(); 

            /* 7. Write a program that converts a hexadecimal number to decimal one.*/

            Console.WriteLine("Enter hexadecimal number to convert to decimal: ");
            string hexaNum = Console.ReadLine();
            int dexNumber = Convert.ToInt32(hexaNum, 16);

            Console.WriteLine($"Decimal form of {hexaNum} is: {dexNumber}");
            Console.WriteLine(); 

            /* 8. Write a program that converts a hexadecimal number to binary one.*/

            Console.WriteLine("Enter hexadecimal number to convert to binary: ");
            string hexadexNumber = Console.ReadLine();
            int numDex = Convert.ToInt32(hexadexNumber, 16);
            string binaNum = Convert.ToString(numDex, 2);

            Console.WriteLine($"Binary form of {hexadexNumber} is: {binaNum}");
            Console.WriteLine(); 

            /* 9. Write a program that converts a binary number to hexadecimal one.*/

            Console.WriteLine("Enter binary number to convert to hexadecimal: ");
            string binaryNumber = Console.ReadLine();
            int numDecimal = Convert.ToInt32(binaryNumber, 2);
            string hexadecimalNumber = numDecimal.ToString("X");

            Console.WriteLine($"Hexadecimal form of {binaryNumber} is: {hexadecimalNumber}");
            Console.WriteLine(); 

            /* 10. Write a program that converts a binary number to decimal using the 
            Horner scheme.*/

            int dex = 0;

            Console.Write("Enter binary number: ");
            string binary = Console.ReadLine();
            int length = binary.Length;
            int power = length - 1;

            for (int i = 0; i < length; i++)
            {
                dex += (int)(int.Parse(binary[i].ToString()) * Math.Pow(2, power));
                power--;
            }

            Console.WriteLine($"Result is {dex}.");
            Console.WriteLine(); 


        }
    }
}
