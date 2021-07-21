using System;

public class Program
{
    public static void Main()
    {
        int Amount;
        Amount = Convert.ToInt32(Console.ReadLine());

       int a= Amount / 10;
       int b=(Amount % 10) / 5;
       int c= (((Amount % 10) % 5) / 1);
        int d= (((Amount % 10) % 5) % 1);
        Console.WriteLine(a + b + c + d);

        Console.ReadKey();
    }
}