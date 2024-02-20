namespace MyApp
{
    class Program
    {
        static void Main(string[] args)
        {
            var fullName = new FullName("Super", "Fortess");
            Console.WriteLine($"Full Name: {fullName.FirstName} {fullName.LastName}");
        }
    }

    class FullName : IEquatable<FullName>
    {   
        public FullName(string firstName, string lastName)
        {
            FirstName = firstName;
            LastName = lastName;
        }
        
        public string FirstName {get;}
        public string LastName {get;}

        public bool Equals(FullName other)
        {
            if(ReferenceEquals(null, other)) return false;
            if(ReferenceEquals(this, other)) return true;
            return string.Equals(FirstName, other.FirstName) && string.Equals(LastName, other.LastName);
        }
    }
} 