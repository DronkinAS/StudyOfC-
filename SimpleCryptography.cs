using System;

public class MainClass
{
    public static void Main()
    {
        string message = Console.ReadLine();
        Console.WriteLine("Исходное сообщение: " + message);
        Console.WriteLine("Шифрованное сообщение: " + GetEncryption(message));
        Console.WriteLine("Дешифрованное сообщение: " + GetDescryption(GetEncryption(message)));
    }
    //Шифрование сообщения
    public static string GetEncryption(string text)
    {      
        char[] charArray = new char[text.Length];
        for (int i = 0; i < text.Length; i++){
            charArray[i] = Convert.ToChar(Convert.ToInt32(text[i])*3);
        }
        string encryptedText = new string(charArray);
        return encryptedText;
    }
    //Дешифрование сообщения
    public static string GetDescryption(string text)
    {      
        char[] charArray = new char[text.Length];
        for (int i = 0; i < text.Length; i++){
            charArray[i] = Convert.ToChar(Convert.ToInt32(text[i])/3);
        }
        string descryptedText = new string(charArray);
        return descryptedText;
    }
}
