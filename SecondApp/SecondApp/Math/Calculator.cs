namespace SecondApp.Math;

public enum ShippingMethod
{
     RegularAirMail = 1,
     RegisteredAirMail = 2,
     Express=3
}
public class Calculator
{
     public static int Add(int a, int b)
     {
          return a + b;
     }
     
     public static void Strings()
     {
          var firstName = "Aakriti";
          var  lastName = "Banjara";
          var fullName = firstName + " " + lastName;
          var myFullName = string.Format("My name is {0} {1}", firstName, lastName);
          var names = new string[3] { "Regal", "Aakriti", "Banjara" };
          var formattedNames = string.Join(",", names);
          Console.WriteLine(formattedNames);
          Console.WriteLine(fullName);
          Console.WriteLine(myFullName);

          var text = @"Hi Regal
Look into the following paths
c:\folder1\folder2
c:\\folder3\\folder4";
          Console.WriteLine(text);
     }

     // for reference and Value
     public static void Value()
     {
          var a = 10;
          var b = a;
          b++;
          Console.WriteLine(string.Format("a: {0} , b: {1}",a,b));
          
          // reference 
          
          var array1 = new int[3] { 1, 2, 3 };
          var array2 = array1;
          array2[0] = 0;
          Console.WriteLine(string.Format("array1[0]: {0}, array2[0]: {1}", array1[0],array2[0]));

     }
     public static void Arrays()
     {
          var numbers = new int[3];
          numbers[0] = 1;
          Console.WriteLine(numbers[0]);
          Console.WriteLine(numbers[1]);
          Console.WriteLine(numbers[2]);

          var flags = new bool[3];
          flags[0] = true;
          Console.WriteLine(flags[0]);
          Console.WriteLine(flags[1]);
          Console.WriteLine(flags[2]);


          var names = new string[3] { "Regal", "Aakriti", "Banjara" };
          Console.WriteLine(names[0]);
          Console.WriteLine(names[1]);
          Console.WriteLine(names[2]);
     }
     
     
}

// example of value and reference 


