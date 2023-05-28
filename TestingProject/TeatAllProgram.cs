//Проект для проверки небольших учебных программ

using System;
using System.Collections.Generic;

public class MainClass
{
    public static void Main()
    {
        Console.WriteLine("Два метода построения симметричного изображения...\n" +
            "Введите высоту башни:");
        
        int height = int.Parse(Console.ReadLine());
        Console.WriteLine("Первый вариант:");
        Var1(height);
        Console.WriteLine("Второй вариант:");
        Var2(height);

        Console.WriteLine("\nМетод проводит шифрование сообщения (ENG):");

        string message = Console.ReadLine();
        Console.WriteLine("Исходное сообщение: " + message);
        Console.WriteLine("Шифрованное сообщение: " + GetEncryption(message));
        Console.WriteLine("Дешифрованное сообщение: " + GetDescryption(GetEncryption(message)));

        Console.WriteLine("\nМетод должен вывести в консоль числа между нулями в порядке убывания:");

        //Формируем массив целых чисел с двумя 0
        int[] input_arr = new int[] {5, 7, 11, 4, 9, 0, 8, 7, 14, 0, 13, 2};
        foreach (int elem in input_arr)
        {
            Console.Write(elem + " ");
        }
        Console.WriteLine();
        FindFromZeroToZero(input_arr);
        Console.WriteLine();

        Console.WriteLine("\nМетод находит позиции символов:");

        string input_str = "простокакой-тотекстдлятогочтобыпроверитьработукода";
        Console.WriteLine(input_str);
        string output_str = SimpleCoder(input_str);
        Console.WriteLine(output_str);
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

    //Шифрование сообщения
    public static string GetEncryption(string text)
    {
        char[] charArray = new char[text.Length];
        for (int i = 0; i < text.Length; i++)
        {
            charArray[i] = Convert.ToChar(Convert.ToInt32(text[i]) * 3);
        }
        string encryptedText = new string(charArray);
        return encryptedText;
    }
    //Дешифрование сообщения
    public static string GetDescryption(string text)
    {
        char[] charArray = new char[text.Length];
        for (int i = 0; i < text.Length; i++)
        {
            charArray[i] = Convert.ToChar(Convert.ToInt32(text[i]) / 3);
        }
        string descryptedText = new string(charArray);
        return descryptedText;
    }

    static void FindFromZeroToZero(int[] input_arr)
    {
        int N0 = Array.IndexOf(input_arr, 0) + 1;
        int N1 = Array.LastIndexOf(input_arr, 0) - 1;
        int[] sorting_arr = new int[N1 - N0 + 1];
        for (int i = 0; i < sorting_arr.Length; i++)
        {
            sorting_arr[i] = input_arr[N0 + i];
        }

        int boo;
        for (int i = sorting_arr.Length - 1; i > 0; i--)
        {
            for (int j = 0; j < i; j++)
            {
                if (sorting_arr[j] < sorting_arr[j + 1])
                {
                    boo = sorting_arr[j];
                    sorting_arr[j] = sorting_arr[j + 1];
                    sorting_arr[j + 1] = boo;
                }
            }
        }

        foreach (int elem in sorting_arr)
        {
            Console.Write(elem + " ");
        }
    }

    static string SimpleCoder(string input_str)
    {
        //Создаём словарь для хранения комбинации "Символ - Список индексов""
        SortedDictionary<char, List<int>> CharAndIndex = new SortedDictionary<char, List<int>>();

        //Заполняем словарь
        int num = 0;
        foreach (char c in input_str)
        {
            if (!CharAndIndex.ContainsKey(c))
            {
                CharAndIndex.Add(c, new List<int>());
            }
            CharAndIndex[c].Add(num);
            num++;
        }

        //Чтобы не выделять каждый раз заново место, формируем строго заданный масив 
        char[] for_create_output = new char[NeedCharsNumber(input_str.Length) + 2 * CharAndIndex.Count + input_str.Length];

        //Заполняем массив необходимыми символами и пробелами
        int i = 0;
        foreach (char key in CharAndIndex.Keys)
        {
            for_create_output[i] = key;
            for_create_output[i + 1] = ' ';
            i += 2;
            foreach (int j in CharAndIndex[key])
            {
                foreach (char c in Convert.ToString(j))
                {
                    for_create_output[i] = c;
                    i++;
                }
                for_create_output[i] = ' ';
                i++;
            }
        }

        return new string(for_create_output);

    }

    //Метод служит для того, чтобы расчитать количество символов, необходимых для вывода числовой последовательности
    static int NeedCharsNumber(int number)
    {
        if (number < 10) return number;
        if (number < 100) return 10 + 2 * (number - 9);
        if (number < 1000) return 190 + 3 * (number - 99);
        return 0;
    }
}
