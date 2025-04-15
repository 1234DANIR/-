using System;

class Algoritm1
{
    public static void Main()
    {
        // Объявление переменных
        int smallNumber = 585;
        int bigNumber = 580;

        // Условная конструкция
        if (bigNumber > smallNumber)
            Console.WriteLine($"{bigNumber} больше, чем {smallNumber}");
        else
            Console.WriteLine($"{bigNumber} меньше, чем {smallNumber}");

        // Инструкция для завершения программы
        Console.WriteLine("Для выхода нажмите Enter");
        Console.ReadLine();
    }
}