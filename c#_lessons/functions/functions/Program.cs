/*
Name: Lochlan Marchinko
Class: Comp Sci 20s
Description: This code deals with functions, mandatory and optional parameters
 */

using System.Transactions;

namespace cheese
{

    public class parmesan
    {
        //void means empty return 
        // a void function does not return anything 
        static void customMessage(String word)
        {
            Console.WriteLine("***"+word+"***");
        }
        // This function take num1 and num2 and returns their sum  
        static int sum(int num1, int num2) 
        {
            return num1 + num2;
        }
        static int product(int num1, int nums2)
        {
            return num1 * nums2;
        }
        static String ToLowerOrUpper(String word, bool tolower) 
        {
        if(tolower)
            {
                return word.ToLower();
            }
        else
            {
                return word.ToUpper();
            }
        }

        public static void Main()
        {
            /*Console.WriteLine("Please enter a word");
            String input = Console.ReadLine();
            //we call functions by their names and () to it 
            //if the function takes input, we put the intput between ()
            customMessage(input);
            customMessage(input);
            customMessage(input);
            //thefunction executesevery time we call it*/
            ///////////////////////////////////////////////////////////////////////////////////////////////////////////
            /*Console.WriteLine("Enter the first number");
            int first = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the second number");
            int second = Convert.ToInt32(Console.ReadLine());
            // when a function returns a value
            // we can store that value in a variable to use it later
            int result = sum(first, second);
            Console.WriteLine("the sum is " + result);*/
            /*Console.WriteLine("Enter the first number");
            int first = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the second number");
            int second = Convert.ToInt32(Console.ReadLine());
            int result = product(first, second);
            Console.Write("the product is "+result);*/
            ///////////////////////////////////////////////////////////////////////////////////////////////////////////
            /*Console.WriteLine("Enter a word");
            string input = Console.ReadLine();
            String changeword = ToLowerOrUpper(input, true);
            Console.WriteLine(changeword);
            changeword = ToLowerOrUpper(input, false);
            Console.WriteLine(changeword);*/

        }

    }

}

