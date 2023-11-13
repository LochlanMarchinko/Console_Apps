/*
Name: Lochlan Marchinko
Class: Comp Sci 20s
Description:
 */

using System.Security.Cryptography.X509Certificates;

namespace switch_statements
{

    public class switches
    {

        public static void Main()
    {
            /* Console.WriteLine("Enter a number from 1 to 12");
             int month = Convert.ToInt32(Console.ReadLine());
             if (month == 1)
              { Console.WriteLine("January"); }
              else if (month == 2)
              { Console.WriteLine("Febuary"); }
              else if (month == 3)
              { Console.WriteLine("March"); }
              else if (month == 4)
              { Console.WriteLine("April"); }
              else if (month == 5)
              { Console.WriteLine("May"); }

             switch (month){//switch helps us compare one value to multiple other cases
                 case 1:
                     Console.WriteLine("January");break;// break is needed to break out of the switch
                 case 2:
                     Console.WriteLine("Febuary");break;
                 case 3:
                     Console.WriteLine("March");break;
                 case 4:
                     Console.WriteLine("April");break;
                 case 5:
                     Console.WriteLine("May");break;
                 case 6:
                     Console.WriteLine("June");break;
                 case 7:
                     Console.WriteLine("July");break;
                 case 8:
                     Console.WriteLine("August");break;
                 case 9:
                     Console.WriteLine("September");break;
                 case 10:
                     Console.WriteLine("October");break;
                 case 11:
                     Console.WriteLine("November");break;
                 case 12:
                     Console.WriteLine("December");break;
                 default: // only executes after all above classes
                     Console.WriteLine("invalid input");break;}*/

            Console.WriteLine("Enter your name to find out your score");
            string name = Console.ReadLine();
            switch (name.ToLower())
            {
                case "greg":
                    Console.WriteLine("85%");break;
                case "magnus":
                    Console.WriteLine("88%"); break;
                case "mann":
                    Console.WriteLine("89%"); break;
                case "lochlan":
                    Console.WriteLine("90%"); break;
                default: Console.WriteLine("Ive never met you in my life");break;



            }




            }

        }


}
