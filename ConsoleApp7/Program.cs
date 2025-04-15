using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class algoritm2
{
    // Главная точка входа приложения
    public static void Main()
    {
        // Инициализация переменных
        int smallNumber = 585;
        int bigNumber = 580;

        // Условная конструкция if-else
        if (bigNumber < smallNumber)
        {
            System.Console.Write(bigNumber);      // Если условие истинно, выводится большее число
            System.Console.Write(" меньше, чем "); // Затем выводится строка
            System.Console.WriteLine(smallNumber);// Наконец, меньшее число и переход на новую строку
        }
        else
        {
            System.Console.Write(smallNumber);   // Иначе наоборот, сначала меньшее число
            System.Console.Write(" меньше, чем ");// Строка снова
            System.Console.WriteLine(bigNumber);  // Затем большее число и новая строка
        }

        // Сообщение пользователю о завершении программы
        System.Console.WriteLine("Для выхода нажмите Enter");
        System.Console.ReadLine();               // Ожидание нажатия клавиши Enter перед закрытием окна
    }
}