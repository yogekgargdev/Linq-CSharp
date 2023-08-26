// Example for IEnumerable

using System.Collections;

Person p = new Person("Yogek", "Garg", "Punjab");
// foreach is applicable on the type "IEnumerable"
foreach (string z in p.NameIEnumerable())
{
    Console.WriteLine(z);
}


////////////////////////////////////////////////

Car CarObj = new Car(1, 2, 3);
foreach(int i in CarObj)
{
    Console.WriteLine(i);
}
Console.WriteLine("FirstOrDefault: " + CarObj.FirstOrDefault());

/// Generation Operations
// Empty IEnumerable
Console.WriteLine(Enumerable.Empty<int>());
// Repeat IEnumerable
Console.WriteLine(Enumerable.Repeat("Hello", 3));
// Range
Console.WriteLine(Enumerable.Range(1, 10));
// Printing letters from a - z
Console.WriteLine(Enumerable.Range('a', 'z' - 'a' + 1).Select(x => (char)x));
// print string with each increaing length by 1, starting from length 1
Console.WriteLine(Enumerable.Range(1, 10).Select(x => new String('x', x)));
///////////////////////////////////

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


// Example for IEnumerable when a class inherits it
public class Car : IEnumerable<int>
{
    public int Id, Id1, Id2;
    public Car(int id, int id1, int id2)
    {
        Id = id;
        Id1 = id1;
        Id2 = id2;
    }

    public IEnumerator<int> GetEnumerator()
    {
        yield return Id;
        yield return Id1;
        yield return Id2;

    }

    IEnumerator IEnumerable.GetEnumerator()
    {
        return GetEnumerator();
    }
}