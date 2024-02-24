using System.Reflection.Metadata.Ecma335;
using MyApp.Models;

namespace MyApp
{
    class Program
    {
        static void Main(string[] args)
        {
            var fullName = new FullName("Super", "Fortess");
            Console.WriteLine($"Full Name: {fullName.FirstName} {fullName.LastName}");

            var someMoney = new Money(1000, "KRW");
            Console.WriteLine($"Amount: {someMoney.Amount}, Currency: {someMoney.Currency}");
        }
    }
}