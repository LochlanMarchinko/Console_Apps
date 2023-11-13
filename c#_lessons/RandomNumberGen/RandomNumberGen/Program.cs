/*
Name: Lochlan Marchinko
Class: Comp Sci 20s
Description:
 */

namespace cheese
{

    public class parmesan
{

    public static void Main()
    {
            Random numR = new Random();
            int num1 = numR.Next(1,10);
            Console.WriteLine("Guess a number between 1 and 10");
            Console.WriteLine(num1);
            bool keeprunning = true;
            while (keeprunning) { int num2 = Convert.ToInt32(Console.ReadLine());
                if (num2 == num1) { keeprunning = false; }
                else Console.WriteLine("Wrong,guess again");}
            Console.WriteLine("You guesssed the right number");
            
        }

    }

}



           
