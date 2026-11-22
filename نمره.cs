

using System;

class Program
{
    static void Main()
    {
        Console.Write("nomre ra vared kon: ");
        float nomre = float (Console.ReadLine());

        if (nomre < 0 || nomre > 20)
        {
            Console.WriteLine("eshtebahe.");
        }
        else if (nomre >= 17 && nomre <= 20)
        {
            Console.WriteLine("aaliiii");
        }
        else if (nomre >= 14 && nomre < 17)
        {
            Console.WriteLine("khoob");
        }
        else if (nomre >= 10 && nomre < 14)
        {
            Console.WriteLine("ghabelghabool");
        }
        else
        {
            Console.WriteLine("mardood");
        }
    }
}