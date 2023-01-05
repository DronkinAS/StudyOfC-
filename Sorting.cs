using System;

public class MainClass
{
    public static void Main()
    {
        string line = Console.ReadLine();
        string[] splitString = line.Split(" ");
        int[] numbers = new int[splitString.Length]; 
        
        for (int i = 0; i < numbers.Length; i++)
        {
            numbers[i] = int.Parse(splitString[i]);
        }
        
        //Простая сортировка пузырьком, позже попробую более интересные методы сортировки
        int number;
        for (int N = numbers.Length - 1; N > 0; N--)
        {
            for (int i = 0; i < N; i++) {
                if (numbers[i] > numbers[i+1]){
                    number = numbers[i+1];
                    numbers[i+1] = numbers[i];
                    numbers[i] = number;
                }
            }
        }
        
        for (int i = 0; i < numbers.Length; i++)
        {
            Console.Write($"{numbers[i]} ");
        }
    }
}
