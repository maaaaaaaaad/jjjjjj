namespace MoneyApp
{
    public class Program
    {
        static void Main(string[] args)
        {
            var money_1 = new Money(1000, "won");
        }
    }

    public class Money
    {
        private readonly decimal amount;
        private readonly string currency;

        public Money(decimal amount, string currency)
        {
            if (currency == null) throw new ArgumentNullException();
            this.amount = amount;
            this.currency = currency;
        }
    }
}