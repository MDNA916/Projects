﻿using System;
    class Program
    {
        static void Main()
        {
        int a = int.Parse(Console.ReadLine());
        int b = int.Parse(Console.ReadLine());

        Console.WriteLine("{0} + {1} = {2}", a,b, a+b);
        Console.WriteLine("{0} + {1} = {2}", a,b, a*b);

        float f = float.Parse(Console.ReadLine());
        Console.WriteLine("{0} * {1} / {2} = {3}", a,b,f,a*b/f);
        }
    }

