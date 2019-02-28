using System;

namespace FullName
{
    public static class Program
    {
        public static void Main()
        {
            // TODO: Ask the user for their first name and then their last name.

            // TODO: Call a method called FullName that returns their full name.

            // TODO: Output their full name.
            string firstName;
            string lastName;

            Console.WriteLine("What is your first name? ");
            firstName = Console.ReadLine();

            Console.WriteLine("What is your last name? ");
            lastName = Console.ReadLine();

            //Console.WriteLine($"{firstName} {lastName}");
            FullName(firstName, lastName);

            Console.ReadLine();
        }
        static void FullName(string firstName, string lastName)
        {
       

            Console.WriteLine($"{firstName} {lastName}");
        }
        
        // TODO: Create a method call FullName that takes the firstName and lastName as parameters.
    }
}
