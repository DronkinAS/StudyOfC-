//Проверка работы некоторых методов для работы с массивами и списками

using System;

public class MainClass
{
    public static void Main(){
        //Формируем массив целых чисел с двумя 0
        int[] input_arr = new int[] {5, 7, 11, 4, 9, 0, 8, 7, 14, 0, 13, 2};
        //Метод должен вывести в консоль числа между нулями в порядке убывания
        FindFromZeroToZero(input_arr);
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
}
