
using System;

class Program
{
    static void Main()
    {
        int choice;
        
        {
            Console.WriteLine("1dayere");
            Console.WriteLine("2mosalas");
            Console.WriteLine("3mostatil");
            Console.WriteLine("4. khorooj");
            Console.Write("Enter number: ");
            choice = int(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    Console.Write("شعاع: ");
                    float r = float(Console.ReadLine());
                    float dayere = 3.14 * r * r;
                    Console.WriteLine(dayere);
                    break;
                case 2:
                    Console.Write("قاعده: ");
                    float b = float(Console.ReadLine());
                    Console.Write("ارتفاع: ");
                    float h = float(Console.ReadLine());
                    double mosalas =(b * h)/2;
                    Console.WriteLine(mosalas);
                    break;
                case 3:
                    Console.Write("طول: ");
                    float l = float(Console.ReadLine());
                    Console.Write("عرض: ");
                    float w = float(Console.ReadLine());
                    double mostatil = l * w;
                    Console.WriteLine(mostatil);
                    break;
                case 4:
                    Console.WriteLine("در حال خروج...");
                    break;
                default:
                    Console.WriteLine("eror");
                    break;
            }

        
    }
}