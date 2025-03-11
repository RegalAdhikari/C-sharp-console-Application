namespace SecondApp;

public class Person
{
    public string FirstName;
    public string LastName;

    public void Introduce()
    {
        Console.WriteLine("My name is " + FirstName + " " + LastName);
    }
    
    public int Age;
    public static void Increment(int number)
    {
        number += 10;
    }

    public static void MakeOld(Person person)
    {
        person.Age += 10;
    }
}
