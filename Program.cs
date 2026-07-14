// SESSION 09 - TODO GUIDE - built live in class, never pre-typed.
// This file intentionally contains ONLY TODO comments. Every real line of code is
// typed live by the instructor, following the Student Guide / Instructor Guide.
// If a live demo breaks, open DotNetJourney_Complete instead.
// (Rule 20 - Live Artifact Is a TODO Guide, Not Working Code)
// (Rule 30 - Explicit Program Class & Main Entry Point - No Top-Level Statements:
//  every TODO below lives INSIDE Main, in the exact position the real code will
//  occupy, never floating above the namespace/class as if it were top-level.)

using System;

namespace DotNetJourney
{
    class Program
    {
        static void Main(string[] args)
        {
            // TODO 1 (Block 3 - Hello World)
            //Console.WriteLine("Hello, World!");

            #region Guides
            // TODO 2 (Block 4 - Variables, all 6 types)
            // int age = 25;
            // double price = 19.99;
            // string name = "Sara";
            // bool isStudent = true;
            // char grade = 'A';
            // var favoriteColor = "Blue";

            // TODO 3 (Block 4 - long + decimal literal, underscores as readability separators)
            // long worldPopulation = 8_100_000_000;
            // decimal price2 = 19.99m;

            // TODO 4 (Block 4 - Casting: implicit widening vs explicit narrowing)
            // double asDecimal = age;
            // int truncated = (int)price;

            // TODO 5 (Block 4 - Escape sequences + verbatim string)
            // string withNewline = "Line one\nLine two";
            // string windowsPath = "C:\\Users\\Sara";
            // string verbatimPath = @"C:\Users\Sara";

            // TODO 6 (Block 4 - const)
            // const double VatRate = 0.14;

            // TODO 7 (Block 4 - Console.ReadLine + interpolation)
            // Console.Write("What is your name? ");
            // string userName = Console.ReadLine();
            // Console.WriteLine($"Hello, {userName}! You are {age} years old.");

            // TODO 8 (Block 4 - ANTI-PATTERN, live-coded, run, then deleted)
            // Console.WriteLine("Hello, " + userName + "! You are " + age + " years old.");
            // (deliberately shown once to compare against interpolation, then removed)

            // TODO 9 (Block 4 - Format specifiers)
            // Console.WriteLine($"{price2:C}");
            // Console.WriteLine($"{price2:F2}");

            // TODO 10 (Block 5, Round 1 - Guided Practice: Personal Info Collector)
            // Build the full console app described in Block 5 of the Student Guide:
            //   header, Name/Age/FavoriteColor/IsStudent prompts, formatted summary print,
            //   "Press any key to exit..." + Console.ReadKey().

            // TODO 11 (Block 5, Round 3 - Guided Practice: Receipt Printer)
            // const decimal VatRate + 3 decimal item prices + subtotal/vatAmount/total,
            // printed with :C or :F2 on every money value. See Student Guide Round 3. 
            #endregion
            //Console.WriteLine("Hello World!");
            //int : whole numbers
            //double , decimal , float : floating numbers 
            //string : text " "
            //bool : true or false
            //char : single character ''
            //
            //int age = 26;
            //long worldPopulation = 8_100_000_000;

            ////age = "Twenty six"; // error cause c# is type safe
            //string name = "Abdelrahman";
            //bool isStudent = true;
            //char grade = 'A';
            //double price = 19.99;
            //float asDouble = 33.3F;
            //string number = "33";
            //var favoriteColor = false;

            //double asDecimal = age; // Implicit Casting From Int To Double (Smaller Data Type To Larger Data Type)
            //int priceInt = (int)Math.Round(price); // Explicit Casting From Double To Int (Larger Data Type To Smaller Data Type)
            //Console.WriteLine(priceInt);
            //int textNumber = int.Parse(number);
            //Console.WriteLine(textNumber);

            //// verbatim string , escape sequences
            //string withNewLine = "Line one\nLine two";
            //string withTab = "Line one\tLine two";
            //string windowsPath = "E:\\Hamdy\\INSTANT\\Round 37\\Sat-Tue\\Session_09_CSharp_GitHub_First_Commit\\Application\\DotNetJourney\\Program.cs";
            //string verbatimPath = @"C:\Users\Sara";

            //// constant
            //const double VatRate = 0.14;
            ////VatRate++;



            //Console.WriteLine(withNewLine);
            //Console.WriteLine(withTab);
            //Console.WriteLine(windowsPath);
            //Console.WriteLine(verbatimPath);


            //Console.WriteLine("What is your name?");
            //var userName = Console.ReadLine();
            //Console.WriteLine("Hello , " + userName + "!"); // Old way of concatenation
            //Console.WriteLine($"Hello, {userName}! You Are {age} years old and your application path is {verbatimPath}"); // New way of concatenation (String Interpolation)

            //Console.WriteLine($"{price:C}");
            //Console.WriteLine($"{price:F2}");

            // TODO: build everything above, live, following the Instructor Guide.


            Console.WriteLine("=== Personal Info Collector ===");
            Console.Write("Enter your name: ");
            var collectedName = Console.ReadLine(); // variable was written in camelCase 
            Console.Write("Enter your Age: ");
            var collectedAge = Console.ReadLine();
            Console.Write("Enter your Favorite Color: ");
            var collectedColor = Console.ReadLine();
            Console.Write("Are you a student? (yes/no): ");
            var collectedIsStudent = Console.ReadLine();

            Console.WriteLine();
            Console.WriteLine("=== Your Info ===");
            Console.WriteLine($"Name : {collectedName}");
            Console.WriteLine($"Age : {collectedAge}");
            Console.WriteLine($"Favorite Color : {collectedColor}");
            Console.WriteLine($"Student : {collectedIsStudent}");



            Console.WriteLine("Receipt Printer......");

            Console.WriteLine("=== Receipt ===");
            const decimal ReceiptVatRate = 0.14m;
            var item1 = 19.99m;
            var item2 = 45.50m;
            var item3 = 12.00m;

            var subtotal = item1 + item2 + item3;
            var vatAmount = subtotal * ReceiptVatRate;

            var total = subtotal + vatAmount;

            Console.WriteLine($"Item 1 : {item1:C}");
            Console.WriteLine($"Item 2 : {item2:C}");
            Console.WriteLine($"Item 3 : {item3:C}");
            Console.WriteLine($"Subtotal : {subtotal:C}");
            Console.WriteLine($"VAT (14%) : {vatAmount:C}");
            Console.WriteLine($"Total : {total:C}");
            Console.WriteLine("\nPress any key to exit...");
            Console.ReadKey();

        }
    }
}
