using System;

class algoritm3
{
    public static void Main()
    {
        int reactorTemp = 150;
        string emergencyValve = "закрыт"; 

        if (reactorTemp <= 1000)
        {
            Console.WriteLine("Температура в реакторе нормальная"); 
            Console.WriteLine("Для выхода из системы диагностики нажмите Enter");
            Console.ReadLine(); 
        }
        else
        {
            Console.WriteLine("Слишком высокая температура в реакторе!"); 

            
            if (emergencyValve == "закрыт") 
            {
                Console.WriteLine("Реактор в процессе плавления!");
                Console.WriteLine("Для открытия аварийного клапана нажмите Enter");
                Console.ReadLine(); 
            }
        }
    }
}
