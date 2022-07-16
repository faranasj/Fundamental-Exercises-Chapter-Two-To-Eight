using System;

namespace ChapterTwo
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            1. Declare several variables by selecting for each one of them the most 
            appropriate of the types sbyte, byte, short, ushort, int, uint, long
            and ulong in order to assign them the following values: 52,130; -115; 
            4825932; 97; -10000; 20000; 224; 970,700,000; 112; -44; -1,000,000; 
            1990; 123456789123456789.
            
            sbyte: -44, -115,  
            byte: 97, 224, 112
            short: -10000, 
            ushort: 20000, 52,130, 1990
            int: -1,000,000 
            uint: 4825932, 970,700,000
            long:
            ulong: 123456789123456789

            2. Which of the following values can be assigned to variables of type float, 
            double and decimal: 5, -5.01, 34.567839023; 12.345; 8923.1234857;
            3456.091124875956542151256683467?

            float: 5, -5.01, 12.345
            double: 34.567839023, 8923.1234857
            decimal: 3456.091124875956542151256683467
            */

            /* 3. Write a program, which compares correctly two real numbers with 
            accuracy at least 0.000001.*/

            Console.Write("Enter first real number:");
            float realNum = float.Parse(Console.ReadLine());
            Console.Write("Enter second real number:");
            float realNumber = float.Parse(Console.ReadLine());
            bool equal = Math.Abs(realNum - realNumber) < 0.000001;

            Console.Write(equal);
            Console.WriteLine();  

            /* 4. Initialize a variable of type int with a value of 256 in
            hexadecimal format (256 is 100 in a numeral system with base 16).*/

            int hexDec = 0x100;
            Console.Write(hexDec);
            Console.WriteLine();

            /* 5. Declare a variable of type char and assign it as a value the character, 
            which has Unicode code, 72 (use the Windows calculator in order to find 
            hexadecimal representation of 72).*/

            char character = '\u0072';
            Console.Write(character);
            Console.WriteLine();

            /* 6. Declare a variable isMale of type bool and assign a value to it depending 
            your gender.*/

            bool isMale = false;
            Console.Write(isMale);
            Console.WriteLine();

            /* 7. Declare two variables of type string with values "Hello" and "World". 
            Declare a variable of type object. Assign the value obtained of 
            concatenation of the two string variables (add space if necessary) to this 
            variable. Print the variable of type object.*/

            string greeting = "Hello ";
            string greetings = "World";
            object greetingCombined = greeting + greetings;
            Console.Write(greetingCombined);
            Console.WriteLine();

            /* 8. Declare two variables of type string and give them values "Hello" and 
            "World". Assign the value obtained by the concatenation of the two 
            variables of type string (do not miss the space in the middle) to a 
            variable of type object. Declare a third variable of type string and 
            initialize it with the value of the variable of type object (you should use 
            type casting).*/

            string greet = "Hello ";
            string greets = "World";
            object greetingsCombined = greet + greets;
            string hello = (string)greetingsCombined;
            Console.Write(hello);
            Console.WriteLine();

            /* 9. Declare two variables of type string and assign them a value “The 
            "use" of quotations causes difficulties.” (without the outer quotes). 
            In one of the variables use quoted string and in the other do not use it.*/

            string quotedSentence = "The \"use\" of  of quotations causes difficulties.";
            string notQuotedSentence = "\u0022The \u0022use\u0022 of quotations causes difficulties.\u0022";
            Console.WriteLine(quotedSentence);
            Console.WriteLine(notQuotedSentence);
            Console.WriteLine();

            /* 10. Write a program to print a figure in the shape of a heart by the sign "o".*/

            Console.WriteLine("     o   o   o      ");
            Console.WriteLine("  o      o       o");
            Console.WriteLine(" o               o  ");
            Console.WriteLine("   o           o  ");
            Console.WriteLine("      o       o");
            Console.WriteLine("          o  ");
            Console.WriteLine();

            /* 11. Write a program that prints on the console isosceles triangle which 
            sides consist of the copyright character "©".*/

            Console.WriteLine("              ©       ");
            Console.WriteLine("            ©   ©   ");
            Console.WriteLine("          ©       ©   ");
            Console.WriteLine("       ©             ©");
            Console.WriteLine("     ©                 ©");
            Console.WriteLine("  ©                       ©");
            Console.WriteLine("©     ©     ©     ©    ©    ©");
            Console.WriteLine();

            /* 12. A company dealing with marketing wants to keep a data record of its 
            employees. Each record should have the following characteristic – first 
            name, last name, age, gender (‘m’ or ‘f’) and unique employee number 
            (27560000 to 27569999). Declare appropriate variables needed to 
            maintain the information for an employee by using the appropriate data 
            types and attribute names.*/

            string firstName;
            string lastName;
            int age;
            char gender;
            uint uniqueEmployeeNumber;
            Console.WriteLine(); 

            /* 13. Declare two variables of type int. Assign to them values 5 and 10 
            respectively. Exchange (swap) their values and print them.*/

            int firstVar = 5;
            int secondVar = 10;
            firstVar = firstVar * secondVar; // 50
            secondVar = firstVar / secondVar; // 5
            firstVar = secondVar + secondVar; // 10

            Console.WriteLine(firstVar);
            Console.WriteLine(secondVar);
            Console.WriteLine();
        }
    }
}
