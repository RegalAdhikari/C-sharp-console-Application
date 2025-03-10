using System;
using HelloWorld.Math;

namespace HelloWorld.Properties
{
    public class Regal
    {
        public static void Sub(string[] args)
        {
            // var aakriti = new Person();
            // aakriti.FirstName = "Aakriti";
            // aakriti.LastName = "Adhikari";
            // aakriti.Introduce();

            // Calculator calculator = new Calculator();
            // var result = calculator.Add(2, 3);
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
            
            Calculator.Value();
        }
        public static void Operators(string[] args)
        {
            try
            {
                string str = "true";
                bool b = Convert.ToBoolean(str);
                Console.WriteLine(b);
            }
            catch (Exception e)
            {
                Console.WriteLine("The number could not be converted to a byte.");
            }
            var a = 10;
            var d = 3;
            var c = 3;
            Console.WriteLine(d == c);
        }
    }
}