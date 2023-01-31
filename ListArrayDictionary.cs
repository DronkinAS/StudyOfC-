using System;
using System.Collections.Generic;

public class MainClass
{
    public static void Main(){
        //Формируем массив целых чисел с двумя 0
        //int[] input_arr = new int[] {5, 7, 11, 4, 9, 0, 8, 7, 14, 0, 13, 2};
        //Метод должен вывести в консоль числа между нулями в порядке убывания
        //FindFromZeroToZero(input_arr);

        string input_str = "купиновуюрулетку";
        string output_str = SimpleCoder(input_str);
        Console.WriteLine(output_str);

    }
    
    static void FindFromZeroToZero(int[] input_arr)
    {   
        int N0 = Array.IndexOf(input_arr, 0) + 1;
        int N1 = Array.LastIndexOf(input_arr, 0) - 1;
        int[] sorting_arr = new int[N1 - N0 + 1];
        for (int i = 0; i < sorting_arr.Length; i++){
            sorting_arr[i] = input_arr[N0 + i];
        }
        
        int boo;
        for (int i = sorting_arr.Length - 1; i > 0; i--){
            for (int j = 0; j < i; j++){
                if (sorting_arr[j] < sorting_arr[j+1]){
                    boo = sorting_arr[j];
                    sorting_arr[j] = sorting_arr[j+1];
                    sorting_arr[j+1] = boo;
                }
            }
        }
        
        foreach (int elem in sorting_arr){
            Console.Write(elem + " ");
        }
    }

    static string SimpleCoder(string input_str)
    {
        //Создаём словарь для хранения комбинации "Символ - Список индексов""
        SortedDictionary<char, List<int>> CharAndIndex = new SortedDictionary<char, List<int>>(); 
        
        //Заполняем словарь
        int num = 0;
        foreach (char c in input_str){
            if (!CharAndIndex.ContainsKey(c)) {
                CharAndIndex.Add(c, new List<int>());
            }
            CharAndIndex[c].Add(num);
            num++;
        }

        //Чтобы не выделять каждый раз заново место, формируем строго заданный масив 
        char[] for_create_output = new char[NeedCharsNumber(input_str.Length) + 2*CharAndIndex.Count + input_str.Length]; 

        int i = 0;
        foreach (char key in CharAndIndex.Keys) {
            for_create_output[i] = key;
            for_create_output[i+1] = ' ';
            i += 2;
            foreach (int j in CharAndIndex[key]){
                foreach (char c in Convert.ToString(j)){
                    for_create_output[i] = c;
                    i++;
                }
                for_create_output[i] = ' ';
                i++;
            }
        }
        
        return new string(for_create_output);
        
    }
    
    static int NeedCharsNumber(int number){
        if (number < 10) return number;
        if (number < 100) return 10 + 2*(number - 9);
        if (number < 1000) return 190 + 3*(number - 99);
        return 0;
    }
}