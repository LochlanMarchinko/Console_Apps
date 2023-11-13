/*
Name: Lochlan Marchinko
Class: Comp Sci 20s
Description: this program takes 3 numbers from the user and finds the biggest one
 */

namespace cheese
{

    public class parmesan
    {

        public static void Main()
        {
            Console.WriteLine("Enter three  different decimal numbers");
            double num1 = Convert.ToDouble(Console.ReadLine());
            double num2 = Convert.ToDouble(Console.ReadLine());
            double num3 = Convert.ToDouble(Console.ReadLine());
            if (num1 > num2 && num1 > num3)
            {
                Console.WriteLine(num1 + " is the biggest number");
            }
            else if (num2 > num1 && num2 > num3)
            {
                Console.WriteLine(num2 + " is the biggest number");
            }
            else if (num3 > num1 && num3 > num2)
            { Console.WriteLine(num3 + " is the biggest number"); }
            else { Console.WriteLine("invalid input"); }
           

        }


    }

}
           
