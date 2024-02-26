using System.Reflection.Metadata.Ecma335;
using dotnet.Models;

namespace dotnet
{
    class Program
    {
        static void Main(string[] args)
        {
            var fullName = new FullName("Super", "Fortress");
            Console.WriteLine($"Full Name: {fullName.FirstName} {fullName.LastName}");

            var someMoney = new Money(1000, "KRW");
            Console.WriteLine($"Amount: {someMoney.Amount}, Currency: {someMoney.Currency}");

            var modelNumber = new ModelNumber("v1", "seoul", "1010101");
            var result = modelNumber.ToString();
            Console.WriteLine(result);

            var userName = new UserName("MAD");
            Console.WriteLine(userName.ToString());
        }
    }
}