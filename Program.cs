using System;

namespace MyApp
{
    class Program
    {
        static void Main(string[] args)
        {
            var fullname = new FullName("Super", "Fortess");
            Console.WriteLine($"Full Name: {fullName.FirstName} {fullName.LastName}");
        }
    }

    class FullName
    {   
        public FullName(string firstName, string lastName)
        {
            FirstName = firstName;
            LastName = lastName;
        }
        
        public string FirstName {get;}
        public string LastName {get;}
    } 
} 