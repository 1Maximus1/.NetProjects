using System;

namespace StudentRequest
{
    class StudentInfo
    {
        static void Main(string[] args)
        {
            string firstName;
            string lastName;
            string groupNumber;

            if (args.Length == 3)
            {
                
                firstName = args[0];
                lastName = args[1];
                groupNumber = args[2];

                Console.WriteLine($"Ім'я: {firstName}");
                Console.WriteLine($"Прізвище: {lastName}");
                Console.WriteLine($"Номер групи: {groupNumber}");
            }
            else
            {
                
                Console.WriteLine("Аргументи не передані, введіть дані вручну.");

                Console.Write("Введіть ім'я: ");
                firstName = Console.ReadLine();

                Console.Write("Введіть прізвище: ");
                lastName = Console.ReadLine();

                Console.Write("Введіть номер групи: ");
                groupNumber = Console.ReadLine();

                Console.WriteLine($"Ім'я: {firstName}");
                Console.WriteLine($"Прізвище: {lastName}");
                Console.WriteLine($"Номер групи: {groupNumber}");
            }

            Console.ReadLine();
        }
    }
}