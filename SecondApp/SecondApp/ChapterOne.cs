namespace SecondApp;

public class ChapterOne
{
    public static void ChapOne(string[] args)
    {
        // byte b = 1;
        // int i = b;
        // Console.WriteLine(i);
        // int i = 1000;
        // byte b = (byte)i;
        // Console.WriteLine(b);
        var number = "1234";
        int i = int.Parse(number); //non compatiable 
        Console.WriteLine(i);

    }

    public static void Try(string[] args)
    {
        try
        {
            var number = "1234";
            byte b = Convert.ToByte(number); 
            Console.WriteLine(b);
        }
        catch (Exception)
        {
            Console.WriteLine("The number could not convert to a byte.");
        }
    }

    public static void Operator(string[] args)
    {
        var a = 10;
        var b = 4;
        var c = 3;
        Console.WriteLine((a + b)*c );
        Console.WriteLine(c>b && c>a);
    }
}