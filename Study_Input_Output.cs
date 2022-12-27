using System;

public class MainClass
{
    //Основной метод
    public static void Main()
    {
        Hello();
        Arithmetic();
    }
    //Приветствие
    public static void Hello(){
        Console.WriteLine("Как тебя зовут?");
        var text = Console.ReadLine();
        Console.WriteLine("Привет, " + text); //Работает с русским текстом, но не с английским
    }
    //Арифметические операции
    public static void Arithmetic()
    {
        Console.WriteLine("Поработаем с числами!");
        Console.WriteLine("Введи первое число");
        var A = double.Parse(Console.ReadLine());
        Console.WriteLine("Введи второе число");
        var B = double.Parse(Console.ReadLine());
        Console.WriteLine($"\nА = {A}, B = {B}");
        Console.WriteLine($"A + B = {A + B}");
        Console.WriteLine($"A - B = {A - B}");
        Console.WriteLine($"A * B = {A * B}");
        Console.WriteLine($"A / B = {A / B}");
        Console.WriteLine($"A % B = {A % B}");
    }
}
