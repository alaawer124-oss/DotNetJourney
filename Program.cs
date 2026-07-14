using System;

// SESSION 09 - TODO GUIDE - built live in class, never pre-typed.
// This file intentionally contains ONLY TODO comments. Every real line of code is
// typed live by the instructor, following the Student Guide / Instructor Guide.
// If a live demo breaks, open DotNetJourney_Complete instead.
// (Rule 20 - Live Artifact Is a TODO Guide, Not Working Code)
// (Rule 30 - Explicit Program Class & Main Entry Point - No Top-Level Statements:
//  every TODO below lives INSIDE Main, in the exact position the real code will
//  occupy, never floating above the namespace/class as if it were top-level.)

namespace DotNetJourney
{
    class Program
    {
        static void Main(string[] args)
        {
            // TODO 1 (Block 3 - Hello World)
            //Console.WriteLine("Hello, World!");

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

            // TODO: build everything above, live, following the Instructor Guide.

            Console.WriteLine("Hello, Worldss!");
        }
    }
}
