using System;
public class TryCatch
{
    static void Main(string[] args)
    {
        int a = 0;
        int b = 10;

        try
        {
            b /= a;
            Console.WriteLine(b /= a);

        }
        catch(DivideByZeroException e)
        {
            Console.WriteLine(e.Message);
        }
       
    }
}
