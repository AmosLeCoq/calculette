﻿using System;
using System.Runtime.CompilerServices;

public class Test
{
    public static void Main()
    {
        int i = 0;
        do
        {
            calcul();
            Console.WriteLine("vous voulez continuer ? (1 pour arreter)(autre pour continuer)");
            i = Convert.ToInt32(Console.ReadLine());
            
        } while (i != 1);   
    }
    
    public static void calcul()
    {
        Console.WriteLine("Num1");

        int num1 = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Num2");

        int num2 = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("1. Addition");
        Console.WriteLine("2. Soustraction");
        Console.WriteLine("3. Multiplication");
        Console.WriteLine("4. Division");

        switch (Console.ReadLine())
        {
            case "1":
                Console.WriteLine(num1 + num2);
                break;
            case "2":
                Console.WriteLine(num1 - num2);
                break;
            case "3":
                Console.WriteLine(num1 * num2);
                break;
            case "4":
                Console.WriteLine(num1 / num2);
                break;
            default:
                Console.WriteLine("Invalid choice");
                break;
        }
    }


    public static char AskUserCharÏnput(string question) {
        return "a";
    }

    public static int AskUserIntegerInput(string question)
    {
        return 0;
    }

    public static void DisplayResult(int op1, char oper, int op2, int result) { }

    public static void DisplayMessage(string message) { }

    public static int Add(int op1, int op2) {
        return 0;
    }

    public static int Substractor(int op1, int op2) {
        return 0;
    }

    public static int Multiply(int op1, int op2)
    {
        return 0;
    }

    public static int Divide(int op1, int op2)
    {
        return 0;
    }


}



