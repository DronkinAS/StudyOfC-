using System;

public class MainClass
{
    public static void Main()
    {
         Console.WriteLine("Как тебя зовут?");
         var text = Console.ReadLine();
         Console.WriteLine("Привет, " + text); //Работает с русским текстом, но не с английским
    }
}
