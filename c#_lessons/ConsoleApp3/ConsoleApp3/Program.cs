
using System.Runtime.ExceptionServices;

namespace baguette{
class HelloWorld {
    static int sum(int num1, int num2)
    {
            return num1 + num2;
        
    }
  static void Main() {
    Console.WriteLine("Enter a number");
        int num1 = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Enter a second number");
        int num2 = Convert.ToInt32(Console.ReadLine());
            int num3 = sum(num1, num2); 
        Console.WriteLine("The sum of the two numbers is " + num3);
  }}
}
