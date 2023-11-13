/*
Name: Lochlan Marchinko
Class: Comp Sci 20s
Description:tThis Program takes a number then adds all thenumbers between 0 and that 
 */

namespace cheese
{

    public class parmesan
    {

        public static void Main()
        {
            Console.WriteLine("Enter an the upper bound");
            int num = Convert.ToInt32(Console.ReadLine());
            int num2 = 0;
            for (int i = 0; i <= num; i++) {Console.WriteLine(i);
                num2 = num2 + i;}
            Console.WriteLine("The total of the numbers is " + num2);

        }

    }


}

