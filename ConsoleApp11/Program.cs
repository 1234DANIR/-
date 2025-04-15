class algoritm5
{
    public static void Main()
    {
        int counter = 17; 
        do
        {
            System.Console.WriteLine("counter = " + counter); 
            counter--;                                      
        }
        while (counter > 1);                              
        System.Console.WriteLine("Для выхода нажмите Enter");
        System.Console.ReadLine();                         
    }
}
