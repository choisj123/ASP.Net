using System;

class MainClass
{
    public static void Main(string[] args)
    {
        Console.WriteLine("1. 변수");
        bool boolVariable = true;
        int intVariable = 10;
        float floatVariable = 3.4f;
        char charVariable = 'a';

        Console.WriteLine(boolVariable);
        Console.WriteLine(intVariable);
        Console.WriteLine(floatVariable);
        Console.WriteLine(charVariable);
        Console.WriteLine("");

        Console.WriteLine("2. 조건문");
        
        int num = 10;

        if (num > 0)
            Console.WriteLine("양수");
        else if (num < 0)
            Console.WriteLine("음수");
        else
            Console.WriteLine("0");

        Console.WriteLine("3. 반복문");

        for (int i = 1; i < 11; i++)
            Console.WriteLine(i);

        int a = 10;
        while (a >= 1)
        {
            Console.WriteLine(a);
            a--;

        }

    }
}

