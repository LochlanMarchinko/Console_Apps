/*
Name: Lochlan Marchinko
Class: Comp Sci 20s
Description: This progam takes a number from the user and makes a star triangle with that many rows
 */

namespace cheese
{

    public class parmesan
    {

        public static void Main()
        {
            Console.WriteLine("Enter the number of rows in the triangle");
            int num = Convert.ToInt32(Console.ReadLine());
            int num2 = 0;
            for (int i = 0; i < num; i++) { for (int i2= 0; i2 <= i; i2++) { Console.Write("*   "); }Console.WriteLine(); }

        }

    }


}

