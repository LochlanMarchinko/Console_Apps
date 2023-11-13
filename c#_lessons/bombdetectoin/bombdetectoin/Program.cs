/*
Name: Lochlan Marchinko
Class: Comp Sci 20s
Description: detects if the word bombis in a scentence
*/
namespace cheese
{

    public class parmesan
    {

        public static void Main()
    {
            Console.WriteLine("Enter your scentence");
            string word = Console.ReadLine();
            string word1 = word.ToLower();
            if (word1.Contains("bomb")) 
            { Console.WriteLine("There is a BOMB in this sentence"); }
            else { Console.WriteLine("there is no bomb in this sentence"); }

    }

}


}
           
