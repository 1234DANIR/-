class algoritm4
{
    public static void Main()
    {
        int counter = -9;           // Начальное значение счётчика
        while (counter <= 5)       // Пока счётчик меньше или равен 5
        {
            System.Console.WriteLine("counter = " + counter); // Вывод текущего значения
            counter++;              // Увеличение счётчика на 1
        }
        System.Console.WriteLine("Нажмите Enter для выхода");
        System.Console.ReadLine();  // Ожидаем нажатия Enter
    }
}