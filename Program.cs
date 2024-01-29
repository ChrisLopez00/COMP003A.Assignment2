/*
 *    Author:     Christopher Lopez
 *    Course:     COMP-003A
 *    Purpose:    Code for Assignment 2
 */
    namespace COMP003A.Assignment2
    {
        internal class Program
        {
            static void Main(string[] args)
            {
                // Console Section
                Console.WriteLine("*****************************************");
                Console.WriteLine("Console Section");
                Console.WriteLine("*****************************************");
                Console.WriteLine("");
                Console.WriteLine("");
                
                Console.Title = "COMP-003A - Assignment 2";
                Console.BackgroundColor = ConsoleColor.DarkBlue;
                Console.ForegroundColor = ConsoleColor.White;
                
                // String Section
                Console.WriteLine("*****************************************");
                Console.WriteLine("String Section");
                Console.WriteLine("*****************************************");
                // Ask First Name
                Console.Write("Please enter your first name:");
                string firstName = Console.ReadLine();
                // Ask Middle Name
                Console.Write("Please enter your middle name:");
                string middleName = Console.ReadLine();
                // Ask Last Name
                Console.Write("Please enter your last name:");
                string lastName = Console.ReadLine();
                // Ask Age
                Console.Write("Please enter your age in 2023:");
                string inputAge = Console.ReadLine();
                int yearBorn = 2023 - Convert.ToInt32(inputAge);
                // Give Birth Year
                Console.WriteLine($"Hello, {firstName} {middleName} {lastName}. You were born in {yearBorn}.");
                Console.WriteLine("");
                Console.WriteLine("");

                Console.WriteLine("*****************************************");
                Console.WriteLine("Math Section");
                Console.WriteLine("*****************************************");

                // Input 1st Integer
                Console.Write("Please enter the first integer:");
                int integer1 = Convert.ToInt32(Console.ReadLine());
                // Input 2nd Integer
                Console.Write("Please enter the second integer:");
                int integer2 = Convert.ToInt32(Console.ReadLine());
                // Sum +
                Console.WriteLine($"{integer1} + {integer2} = {integer1 + integer2}");
                // Difference -
                Console.WriteLine($"{integer1} - {integer2} = {integer1 - integer2}");
                // Multiply *
                Console.WriteLine($"{integer1} * {integer2} = {integer1 * integer2}");
                // Divide /
                Console.WriteLine($"{integer1} / {integer2} = {integer1 / integer2}");
                // Remainder %
                Console.WriteLine($"{integer1} % {integer2} = {integer1 % integer2}");
                Console.WriteLine("");
                Console.WriteLine("");

                // Circle Section
                Console.WriteLine("*****************************************");
                Console.WriteLine("Circle Area & Circumference Calculator Section");
                Console.WriteLine("*****************************************");
                

                // Enter Radius
                Console.Write("Please enter the radius of the circle:");
                double radius = Convert.ToDouble(Console.ReadLine());
                // Area & Circumference Calculation
                double area = Math.PI * Math.Pow(radius, 2);
                double circumference = 2 * Math.PI * radius;
                // Area & Circumference Calculation Output
                Console.WriteLine($"The area of the circle is: {area}");
                Console.WriteLine($"The circumference of the circle is: {circumference}");

            }
        }
    }