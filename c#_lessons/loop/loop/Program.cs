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
            /*int counter = 10;

        beginning: //this is a label
            Console.WriteLine(counter);
            counter = counter - 1;

            if (counter >= 0) {
                goto beginning; // going back to the label
            }*/
            /* int counter1 = 1000;

             while (counter1 > 0) // condition must be true for code to work
             {// the code must be false at soem point to prevent an infinite loop
                 Console.WriteLine(counter1);
                     counter1++; 
             }*/
            //////////////////////////////////////////////////////////////////////////////////////////////////////////////////
            /* bool keeprunning = true;
             string decission = "n";
             while (keeprunning)
             {
                 Console.WriteLine("This code is running do you want to stop it?");
                 Console.WriteLine("press y for yes n for no");
                 decission = Console.ReadLine();

                 if (decission == "y")
                 { keeprunning=false;}
             }*/
            /*do {  
             // do-while will always work atleast once because it preforms the action then checks the condition regardless whether it is true of false
               Console.WriteLine("This loop is working");} while (1 > 2);
            //this condidtion needs to be true to activate more than once*/
            /*int num = 1;
            do{Console.WriteLine(num);
                num++;} while (num <= 10);*/
            //////////////////////////////////////////////////////////////////////////////////////////////////////////////////
            /*for (int num =  0; num < 10; num++) {Console.WriteLine(num+1);}
             */
            /*for (int num = 10; num <= 100; num += 10) { Console.WriteLine(num); }
             */
            /*for (int num = 10; num >= 1; num--) { Console.WriteLine(num); }
             */
            /*for (int num = 1; num > 0;  num++) { Console.WriteLine(num); } // an infinite loop because the expression never becomes false 
             */
            //////////////////////////////////////////////////////////////////////////////////////////////////////////////////
            /*String[] names = { "greg", "Mann", "Magnus", "martin" };
            for (int num = 0; num < names.Length; num++) { Console.WriteLine(names[num]); }
            //there is a better way
            foreach(String name in names) { Console.WriteLine(name); }*/
            /*int[] nums = { 10, 20, 30, 100 };
            foreach (int num in nums) { Console.WriteLine(num); }*/
        }
    }
}