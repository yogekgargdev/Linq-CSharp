// Example for IEnumerable

Person p = new Person("Yogek", "Garg", "Punjab");
// foreach is applicable on the type "IEnumerable"
foreach (string z in p.NameIEnumerable())
{
    Console.WriteLine(z);
}

Console.ReadLine();
public class Person
{
    public string FirstName, MiddleName, LastName;

    public Person(string firstName, string middleName, string lastName)
    {
        FirstName = firstName;
        MiddleName = middleName;
        LastName = lastName;
    }
    public IEnumerable<string> NameIEnumerable()
    {
        yield return FirstName;
        yield return MiddleName;
        yield return LastName;
    }
}

// Example for IEnumerable