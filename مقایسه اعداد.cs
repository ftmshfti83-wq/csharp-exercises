


using System;

class Program
{
    static void Main()
    {
       
        Console.Write("عدد اول: ");
        float n1 = float(Console.ReadLine());

        Console.Write("عدد دوم: ");
        float n2 = float(Console.ReadLine());

        Console.Write("عدد سوم: ");
        float n3 = float(Console.ReadLine());

       
        if (n1 > n2)
        {
            if (n1 > n3)
            {
                Console.WriteLine("عدد اول بزرگتر است");
            }
            else
            {
                Console.WriteLine("عدد سوم بزرگتر است");
            }
        }
        else
        {
            if (n2 > n3)
            {
                Console.WriteLine("عدد دوم بزرگتر است");
            }
            else
            {
                Console.WriteLine("عدد سوم بزرگتر است");
            }
        }
    }
}