using System;

class Program
{
    static void Main()
    {

        Console.Write("sal tavalod?");
        int tavalod = int (Console.ReadLine());

        int age = 1405 - birthYear;

     
        if (age < 12)
        {
            Console.WriteLine("koodak");
        }
        else if (age < 18)
        {
            Console.WriteLine("nojavan");
        }
        else if (age < 60)
        {
            Console.WriteLine("bozogsal");
        }
        else if (age > 60)
        {
            Console.WriteLine("salmand");
        }
        else
            Console.WriteLine("nadorost");

    }
}