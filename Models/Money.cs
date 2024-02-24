using System;

namespace MyApp.Models
{
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