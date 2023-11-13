/*
Name: Lochlan Marchinko
Class: Comp Sci 20s
Description: this program takes two numbers from the user and finds all the odd numbers between them
 */

namespace parmsan
{

    public class cheese
    {

        public static void Main()
    {
            Console.WriteLine("Enter the upper limit");
            int num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the lower limit");
            int num2 = Convert.ToInt32(Console.ReadLine());
            if (num2 % 2 == 0) { num2++; }
        beginning: 
            Console.WriteLine(num2);
            num2 = (num2 + 2);
            if (num2 <= num1) {goto beginning;}
            
            
            
            




            

        }

}


}
           
