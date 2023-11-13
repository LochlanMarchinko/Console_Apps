/*
Name: Lochlan Marchinko
Class: Comp Sci 20s
Description: this code deals with optional parameters (input)
 */

namespace cheese
{

    public class parmesan
    {
        //when writing a fuction,if the variable does not have
        //an initail value like string word, it is mandatory
        // if the variable has an initial value like bool showsstars=false  
        //it is optional
        static void customMessage(String word, bool showstars=false) 
        {
            /*with operational input, if the user sends an input, 
            the variable will use the users input
            if the user does not send anything,
            the variable will use the initail(default) value*/
            if (showstars) {
                Console.WriteLine("***" + word + "***");
                    }
            else { Console.WriteLine(word); }
        }
        static void burger(String order, bool extracheese=false) 
        {if (extracheese) { Console.WriteLine("you want a "+order + " with extra cheese"); }       
        else { Console.WriteLine("you want a " + order); }
        }
        public static void Main()
        {
            /*Console.WriteLine("Enter a word");
            String intput = Console.ReadLine();
            customMessage(intput);
            customMessage(intput, true);*/
            Console.WriteLine("What is your order?");
            string order = Console.ReadLine();
            Console.WriteLine("Do you want extra cheese?");
            string cheese = Console.ReadLine();
            cheese = cheese.ToLower();
            if (cheese.Contains("yes"))
                { burger( order, extracheese:true); }
            else { burger(order); }
        }

    }

}

