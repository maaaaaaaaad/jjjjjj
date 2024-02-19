var fullName = "B-29 Super Fortess";
var token = fullName.Split(" ");
var model = token[0];
Console.WriteLine(model);

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

var fullName = new FullName("Super", "Fortess");