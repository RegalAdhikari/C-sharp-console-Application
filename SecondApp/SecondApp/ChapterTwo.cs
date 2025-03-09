using HelloWorld;
using SecondApp.Math;

namespace SecondApp;

public class ChapterTwo
{
    public static void ChapterTwoMain(string[] args)
    { 
        var p1 = new Person();
        p1.FirstName = "Peter";
        p1.LastName = "Smith";
        p1.Introduce();
        
        var calculator = new Calculator();
        var result= calculator.Add(1, 2);
        Console.WriteLine(result);
    }
}