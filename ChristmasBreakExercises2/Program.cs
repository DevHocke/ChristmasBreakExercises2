using System;

namespace ChristmasBreakExercises2
{
    class Program
    {

        //1. Skapa ett program som ber användaren skriva in 3 nummer
        //2. Addera talen
        //3. Skriv ut summan
        //4. Skriv sedan ut dem i storleks ordning.Störst först
        static void Main(string[] args)
        {
            Console.WriteLine("Write a number: ");
            int one = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Write a second number: ");
            int two = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Write a third number: ");
            int three = Convert.ToInt32(Console.ReadLine());
           
            int sum = one + two + three;

            Console.WriteLine($"Summan av talen är {sum}");
            int[] numbers = new int[3] { one, two, three };

            Array.Sort(numbers);
            Array.Reverse(numbers);

            foreach (var item in numbers)
            {
                Console.WriteLine(item);
            }
            
        }
        
    }
}
