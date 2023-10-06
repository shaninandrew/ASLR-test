// See https://aka.ms/new-console-template for more information
try
{
    Console.WriteLine(">");

    //входное значение
    int i = 0;
    if (args.Length > 0)
    {
        //входное значение
        i = int.Parse(args[0]) + 1;
    }

    AppDomain domain = AppDomain.CurrentDomain;


    //AppDomain Another = AppDomain.CreateDomain("new_dom");
    //сама программа
    string[] parms = new string[1] { i.ToString() };
    Console.WriteLine($"Запуск - передано {i}");

    if (i < 1936)
    {
        try
        {
            Console.WriteLine($" *  Память {GC.GetTotalAllocatedBytes() / 1000} кб  - общий объем {GC.GetTotalMemory(false) / 1000} Кб");
            domain.ExecuteAssembly("ASLR test.dll", parms);
            Console.WriteLine($"===> {i} ");
        }
        catch (StackOverflowException ex)
        { }
    }
}
catch (StackOverflowException ex)
{
    Console.WriteLine("Все... стоп!");
}

