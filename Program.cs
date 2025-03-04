﻿using System;
using System.Diagnostics.Tracing;
class Program
{
    public static int MAX(int a, int b)
    {
        if (a > b)
            return a;
        else
            return b;
    }
    public static int MIN(int a, int b)
    {
        if (a < b)
            return a;
        else
            return b;
    }
    static void Main(string[] args)
    {
        try
        {
            List<int> list = new List<int>();
            long sum = 0;
            string[] lines = File.ReadAllLines("C:\\Users\\Alena\\1.txt");
            foreach (var line in lines)
            {
                int number;
                int number1;
                string[] words = line.Split(' ');
                bool a = int.TryParse(words[0], out number);
                bool b = int.TryParse(words[1], out number1);
                if (a && b)
                {
                    int c = MAX(number, number1);
                    int d = MIN(number, number1);
                    sum += c;
                    int e = c - d;
                    
                    list.Add(e);
                }
            }
            if (sum % 3 != 0)
            {
                Console.WriteLine("Максимальное число суммы значений из пар, не кратное 3: " + sum);
            }
            else
            {
                long min = list.Min(a => a);
                long sum1 = sum - min;
                Console.WriteLine("Максимальное число суммы значений из пар, не кратное 3: " + sum1 );
            }
        }
        catch (Exception e)
        {
            Console.WriteLine(e.ToString());
        }
    }
}