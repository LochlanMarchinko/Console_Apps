using System.Runtime.CompilerServices;

namespace Instructions
{
    public class instruct
    {
        public static void Main()
        {
            /*Console.WriteLine("Hello world");

            int age = Convert.ToInt32(Console.ReadLine());
            double score = Convert.ToDouble(Console.ReadLine());

            string name = Console.ReadLine();

            bool keeprunning = false;
            //or
            bool Keeprunning = true;

            string name1 = Console.ReadLine();
            string name2 = Console.ReadLine();
            string name3 = Console.ReadLine();

            string[] people = {name1, name2, name3 };
            Console.WriteLine(people[0]);//prints the value of name1
            Console.WriteLine(people[1]);//prints the value of name2
            Console.WriteLine(people[2]);//prints the value of name3

            if(4 > 5)
            {Console.WriteLine("this message was printed because 4 is less than 5"); }

            bool trueorfalse = true;
                if (trueorfalse)
            { Console.WriteLine("this prints if the bool was true"); }
                else
            { Console.WriteLine("This prints if the bool was false"); }

                int grade = Convert.ToInt32(Console.ReadLine());
            switch (grade)
            {
                case 9:
                    Console.WriteLine("You are in grade 9");
                    break;
                case 10:
                    Console.WriteLine("You are in grade 10");
                    break;
                case 11:
                    Console.WriteLine("You are in grade 11");
                    break;
                case 12:
                    Console.WriteLine("You are in grade 12");
                    break;
                default:
                    Console.WriteLine("You are not in highschool");
                    break;


            }

            int counter = 1;
        beginning:
            Console.WriteLine("This is the " + counter + " time to print this message");
            if(counter < 10)
            {counter++;
                    goto beginning; }
        
            for(int i = 1; i <= 10; i++) 
            { Console.WriteLine("This is the " + i + " time to print this message"); }

            int counter = 1; 
            while (counter <= 10) { Console.WriteLine(" This is the " + counter + "time to print this message");
                counter++;
            }

            int counter = 1;
            bool keeprunning = true;
            while (keeprunning) 
            { 
                Console.WriteLine("This is the " + counter + "time to print this message");
                counter++;
                if (counter > 10) { keeprunning = false; }
            }

            int counter = 1;
            do
            {
                Console.WriteLine(counter);
                counter++;
            }while (counter <= 10);*/

            String[] nameS = { "Greg", "Mann", "Zadius" };
            int[] ageS = { 14, 14, 15, };
            foreach (String name in nameS) { Console.WriteLine(name); }
            foreach (int age in ageS) { Console.WriteLine(age); }


        }
    }
}