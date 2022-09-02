using System;
using System.Runtime.CompilerServices;

public class Test
{
    public static void Main()
    {
        int i = 0;
        do
        {
            System.Console.Clear();
            calcul();
            DisplayMessage("vous voulez continuer ? (1 pour arreter)(autre pour continuer)");
            i = Convert.ToInt32(Console.ReadLine());
            
        } while (i != 1);   
    }
    
    public static void calcul()
    {

        int num1 = AskUserIntegerInput("Num1");

        int num2 = AskUserIntegerInput("Num2");

        
        

        

        switch (AskUserCharÏnput("+ Addition\n- Soustraction\n* Multiplication\n/ Division"))
        {
            case '+':

                DisplayResult(num1,'+',num2, Add(num1, num2));
            
                break;
            case '-':

                DisplayResult(num1, '-', num2, Substractor(num1, num2));
                break;
            case '*':

                DisplayResult(num1, '*', num2, Multiply(num1, num2));
                break;
            case '/':

                DisplayResult(num1, '/', num2, Divide(num1, num2));
                break;
            default:
                DisplayMessage("Invalid choice");
                break;
        }
    }
    

    public static char AskUserCharÏnput(string question) 
    {
        DisplayMessage(question);
        return Convert.ToChar(Console.ReadLine()); ;
    }

    public static int AskUserIntegerInput(string question)
    {
        DisplayMessage(question);
        

        return Convert.ToInt32(Console.ReadLine());
    }

    public static void DisplayResult(int op1, char oper, int op2, int result) 
    {
        DisplayMessage("Vous avez effectuer " + op1 + oper + op2 + " est = " + result);
    }

    public static void DisplayMessage(string message) 
    {
        Console.WriteLine(message);
    }

    public static int Add(int op1, int op2) 
    {
        return op1 + op2;
    }

    public static int Substractor(int op1, int op2) 
    {
        return op1 - op2;
    }

    public static int Multiply(int op1, int op2)
    {
        return op1 * op2;
    }

    public static int Divide(int op1, int op2)
    {
        return op1 / op2;
    }


}



