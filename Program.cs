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


    class Money
    {
        public Money(decimal amount, string currency)
        {
            if (currency == null) throw new ArgumentException(nameof(currency));
            Amount = amount;
            Currency = currency;
        }

        public decimal Amount { get; }
        public string Currency { get; }

        public Money Sum(Money arg)
        {
            if (arg == null) throw new ArgumentNullException(nameof(arg));
            if (this.Currency != arg.Currency) throw new ArgumentException();
            return new Money(this.Amount + arg.Amount, this.Currency);
        }
    }
}