// See https://aka.ms/new-console-template for more information

using SecondApp.Math;

namespace SecondApp
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            // ChapterOne.ChapOne(args);
            // ChapterOne.Try(args);
            // First(args);
            // ChapterOne.Operator(args);
            
            // ChapterTwo.ChapterTwoMain(args);
            // int result = Calculator.Add(3, 4);
            // Console.WriteLine(result);
            
            // Calculator.Arrays();
            // Calculator.Strings();
            
        /*
             var method = ShippingMethod.Express;
             Console.WriteLine((int)method);
             var methodId = 3;
             Console.WriteLine((ShippingMethod)methodId);
             Console.WriteLine(method.ToString());

             var methodName = "RegularAirMail";
             var shippingMethod =(ShippingMethod) Enum.Parse(typeof(ShippingMethod), methodName);
             Console.WriteLine(shippingMethod);
        */    
         
        // Calculator.Value();

        var number = 1;
        Person.Increment(number);
        Console.WriteLine(number);

        var person = new Person() { Age = 20 };
        Person.MakeOld(person);
        Console.WriteLine(person.Age);
        
        }

        public static void First(string[] args)
        {
            // Console.WriteLine("Hello World");
            byte number = 2;
            int count = 10;
            float totalPrice = 20.50f;
            char character = 'A';
            string firstName = "Aakriti and Regal";
            var isWorking = false;

            Console.WriteLine(totalPrice + count);
            Console.WriteLine(number);
            Console.WriteLine(count);
            Console.WriteLine(character);
            Console.WriteLine(isWorking);
            Console.WriteLine("{0} {1}", byte.MinValue, byte.MaxValue);
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

// Console.WriteLine("Hello, World!");