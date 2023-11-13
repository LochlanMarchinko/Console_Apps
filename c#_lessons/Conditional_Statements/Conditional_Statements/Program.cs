/*
 Name: Lochlan
Classs: Comp Sci 20s
 Description:This program take a number from the user than determins if the number is less than 10 or not
 */

namespace ConsoleApp1
{

    public class standardoutin
    {

        public static void Main()
        {
            /* Console.WriteLine("Enter the number");
             int num = Convert.ToInt32(Console.ReadLine());
             // <= means less than or equal to
             // >= means greater or less than 
             // != means not equal to 

             // < means less than
             if (num < 10) 
             {
                 Console.WriteLine(" the number is less than 10");
             }
             // == means equal to
             else if (num == 10)

                 Console.WriteLine("the number is 10");

             else
             {
                 Console.WriteLine("the number is greater than 10 ");
             }*/
            /* Console.WriteLine("Enter your Grade percent");
             int num= Convert.ToInt32(Console.ReadLine());

             if (num > 89)
             {
                 Console.WriteLine("Your grade is an A!");
             }
             else if (num > 79)
             {
                 Console.WriteLine("Your grade is a B!");
             }
             else if (num > 69)
             {
                 Console.WriteLine("Your grade is a C");
             }
             else if (num > 59)
             {
                 Console.WriteLine("Your grade is an D");
             }
             else if (num > 49)
             {
                 Console.WriteLine("Your grade is an E");
             }
             else 
                 Console.WriteLine(" your grade is an F");*/
            /*bool isskyblue = true;
            bool isfoodready = true;
            // with && operator the statemnet only executes if all conditions are true
            // true && false = false
            // false && trues = false
            // false && false = false 
            // true && trues = true
            if (isskyblue && isfoodready ) { Console.WriteLine("Nice we can go for a picnic"); }
            else {Console.WriteLine("oh no we cant go"); }
            */
            /*Console.WriteLine("Enter your grade to see if you are allowed on the feild trip");
            int grade = Convert.ToInt32(Console.ReadLine());

            // with the || (or) operator only one condition needs to be true
            // false || true = true
            // false || false = false
            // true || true = true
            if(grade == 11 || grade == 12)
            {
                Console.WriteLine("You can go on the feild trip");
            }
            else { Console.WriteLine("No, you can not go on the feild trip"); }*/

            Console.WriteLine("Enter your grade to see if you are allowed on the feild trip");
            int grade = Convert.ToInt32(Console.ReadLine());

            if (grade != 12 && grade != 11)
                Console.WriteLine(" No you are not allowed on the feild trip");
            else Console.WriteLine(" yes you are allwoed on the trip");

        }

    }

}
