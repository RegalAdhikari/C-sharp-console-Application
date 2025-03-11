using System;

namespace HelloWorld.Properties
{
    public class Person
    {
        public string FirstName;
        public string LastName;
        public int Age;
        public void Introduce()
        {
            Console.WriteLine("My name is " + FirstName + " " + LastName);
        }

        public static void Increment(int number)
        {
            number += 10;
        }

        public static void MakeVoid(Person person)
        {
            person.Age += 10;
        }
    }
}