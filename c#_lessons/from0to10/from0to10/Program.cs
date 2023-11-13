/*
Name: Lochlan Marchinko
Class: Comp Sci 20s
Description: this program takes a number from the user and says if it is between 0 and 10
 */

namespace cheese
{

    public class parmesan
    {

        public static void Main()
    {
            Console.WriteLine("Enter your number");
            int num = Convert.ToInt32(Console.ReadLine());
            if (num > -1 && num < 11)
                Console.WriteLine(num + " is between 0 and 10");
            else Console.WriteLine(num + " is not between 0 and 10");

    }

}


}
           
