using System;
using HelloWorld.Properties;

namespace HelloWorld
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            var number = 1;
            Person.Increment(number);
            Console.WriteLine(number);

            var person = new Person() { Age = 20 };
            Person.MakeVoid(person);
            Console.WriteLine(person.Age);
            // First(args);
            Regal.Sub(args);
            // Regal.Operators(args);
            
        }
        public static void First(string[] args)
        {
            byte number= 2 ;
            int count = 10;
            float totalPrice = 20.50f;
            char character = 'A';
            string firstName = "Aakriti and Regal";
            var isWorking = false;
            
            Console.WriteLine(totalPrice+count);
            Console.WriteLine(number);
            Console.WriteLine(count);
            Console.WriteLine(character);
            Console.WriteLine(isWorking);
            Console.WriteLine("{0} {1}",byte.MinValue, byte.MaxValue);
            const float Pi = 3.14f;
            Console.WriteLine(Pi);
        
            
            // Type conversion 
            // int i = 1;
            // byte b = i;  explicit 
            // byte b = (byte)i;
            string s = "1";
            int i = Convert.ToInt32(s);
            int j = int.Parse(s);
            Console.WriteLine(s);
            Console.WriteLine(j);
            Console.WriteLine(i);
        }
    }
}