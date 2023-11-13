/*
Name: Lochlan Marchinko
Class: Comp Sci 20s
Description: this program takes the users hourly wage and hours worked and finds the regular pay, the overtime pay and the total pay
 */

using System.Xml.Schema;

namespace cheese 
{

    public class parmesan
    {

        public static void Main()
    {
            Console.WriteLine("Enter your hourly wage");
            double wage = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter your hours worked");
            double hours = Convert.ToDouble(Console.ReadLine());
            double reg;
            double over;
            double total;
            if (hours > 40)
            {
                over = ((hours - 40) * wage * 1.5);
                reg = (40 * wage);
                total = over + reg;
            }
            else
            {
                reg = (hours * wage);
                over = 0;
                total = reg;
            }
            Console.WriteLine("Your regular pay is " + reg);
            Console.WriteLine("Your overtime pay is " + over);
            Console.WriteLine("your total pay is " + total);
        }

}


}
           
