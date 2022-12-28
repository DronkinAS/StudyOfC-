//Данная программа позволяет рисовать симметричные картины в консоли двумя разными способами 

using System;

public class MainClass
{
    public static void Main()
    {
        int height = int.Parse(Console.ReadLine());
        Console.WriteLine("Первый вариант:");
        Var1(height);
        Console.WriteLine("Второй вариант:");
        Var2(height);
    }
    //Полная симметрия
    public static void Var1(int height)
    {      
        int length = 2*height - 1;
        int center = height - 1;
        
        char[] line = new char[length];
        for (int i = 0; i < length; i++)
        {
            line[i] = '1';
        }
        string output = "";
        for (int i = 0; i <= center; i++){
            for (int j = center - i; j <= center + i; j++){
                line[j] = '*';
            }
            output = string.Join("", line);
            Console.WriteLine(output);
        }
    }
    //Псевдосимметрия
    public static void Var2(int height)
    {      
        string stars = "*";
        string voidString = "";
        while(stars.Length <= 2*height - 1)
        {
            for (int i = 0; i < height - (stars.Length + 1)/2; i++)
            {
              voidString += "1";
            }
            Console.WriteLine(voidString + stars);
            stars += "**";
            voidString = "";
        }
    }
}
