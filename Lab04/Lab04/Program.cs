using System;
using System.IO;
public class switchLearning
{
    public static void Main()
    {
        Console.Write("Input Day Name (sun, mon, tue, wed, thu, fri and sat) : ");
        string day = Console.ReadLine();
        string message;
        switch (day)

        {
            case "sun":
                message = "Sun is Sunday, color Red";
                break;
            case "mon":
                message = "Mon is Monday, color Yellow";
                break;
            case "tue":
                message = "Tue is Tuesday, color Pink";
                break;
            case "wed":
                message = "Wed is Wednesday, color Green";
                break;
            case "thu":
                message = "Thu is Thursday, color Orange";
                break;
            case "fri":
                message = "Fri is Friday, color Blue";
                break;
            case "sat":
                message = "Sat is Saturday, color Purple";
                break;
            default:
                message = "Incorrect Day Name";
                break;
        }
        Console.WriteLine(message);
    }
}
