/*
Name: Lochlan Marchinko
Class: Comp Sci 20s
Description:
 */

using System.Transactions;

namespace cheese
{

    public class parmesan
    {

        public static void Main()
        {
            Console.WriteLine("Enter the Model of car");
            string model = Console.ReadLine();
            Console.WriteLine("Enter the makeyear of car");
            int makeyear = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the mileage of car");
            int mileage = Convert.ToInt32(Console.ReadLine());
            bool incar = true;
            while (incar)
            {
                Console.WriteLine("What would you like to do? Press 1 To Drive. Press 2 To Honk the horn. Press 3 to  exit the vehicle");
                int num = Convert.ToInt32(Console.ReadLine());
                if (num == 1)
                {Console.WriteLine("How much would you like to drive");
                    int num2 = Convert.ToInt32(Console.ReadLine());
                    mileage = (num2 + mileage);
                    Console.WriteLine("The mileage is now " + mileage);}
                if (num == 2) { Console.WriteLine("Beep Beep"); }
                if (num == 3) { Console.WriteLine("You left the car");
                    incar = false;}
                if (num > 3) { Console.WriteLine("Invalid input"); }
            }
       

        }
    }


}

