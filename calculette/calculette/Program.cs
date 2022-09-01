using System;

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
}

