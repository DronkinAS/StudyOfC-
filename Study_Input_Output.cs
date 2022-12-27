using System;

public class MainClass
{
    //Основной метод
    public static void Main()
    {
        //Ниже закоментирован код, отвечающий за тестирование различных методов
        
        //1. Проверка приветствия
        //Hello();
        
        //2. Проверка основных арифметических операций
        //Arithmetic();
        
        //3. Проверяем работу конвертера
        //Console.WriteLine("Проверяем преобразование из демятичной ситемы в шестнадцатиричную");
        //int decNumber = 256;
        //Console.WriteLine($"Исходное число: {decNumber}, в шестнадцатиричной: {decimalToHex(decNumber)}");
        
        //4.Проверяем работу функции минимума
        Console.WriteLine("Введите последовательность чисел через пробел");
        Console.WriteLine($"Наименьшее число - это {simpleMin(Console.ReadLine())}");
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
    //Преобрахование мз 10-ой в 16-ую
    public static string decimalToHex(int decNumber)
    {
        string hexabc = "0123456789abcdef";
        string result = "";
        
        while(true)
        {
            if (decNumber/16 >= 1)
            {
                result = hexabc[decNumber % 16] + result;
                decNumber /= 16;
            }
            else
            {
                result = hexabc[decNumber % 16] + result;
                break;
            }
        }
        
        return result;
    }
    //Метод находит минимальное число, на вход подаётся строка
    public static double simpleMin(string input) {
        string[] splitString = input.Split(' ');
        double[] doubleInput = new double[splitString.Length];
        int i = 0;
        double min = 0;
        while(i < splitString.Length)
        {
            doubleInput[i] = Convert.ToDouble(splitString[i]);
            if (i == 0) {
                min = doubleInput[i];
            }
            else if (doubleInput[i] < min){
                min = doubleInput[i];
            }
            i++;
        }
        return min;
    }
}
