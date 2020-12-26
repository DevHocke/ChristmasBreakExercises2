using System;

namespace ChristmasBreakExercises2
{
    class Program
    {

        //1. Skapa ett program som ber användaren skriva in 3 nummer
        //2. Addera talen
        //3. Skriv ut summan
        //4. Skriv sedan ut dem i storleks ordning.Störst först
        //static void Main(string[] args)
        //{
        //    Console.WriteLine("Write a number: ");
        //    int one = Convert.ToInt32(Console.ReadLine());
        //    Console.WriteLine("Write a second number: ");
        //    int two = Convert.ToInt32(Console.ReadLine());
        //    Console.WriteLine("Write a third number: ");
        //    int three = Convert.ToInt32(Console.ReadLine());

        //    int sum = one + two + three;

        //    Console.WriteLine($"Summan av talen är {sum}");
        //    int[] numbers = new int[3] { one, two, three };

        //    Array.Sort(numbers);
        //    Array.Reverse(numbers);

        //    foreach (var item in numbers)
        //    {
        //        Console.WriteLine(item);
        //    }

        //}
        //------------------------------------------------------------------------------------------------------------------------

        //5. Skapa ett program som tar in två nummer a och b
        //6. Värdet av a ska ligga i b och värdet av b ska ligga i a.Variablerna skall byta värde helt enkelt.

        //static void Main(string[] args)
        //{
        //    int a;
        //    int b;
        //    int c = 0;

        //    Console.WriteLine("Skriv ett tal a: ");
        //    a = Convert.ToInt32(Console.ReadLine());
        //    Console.WriteLine("Skriv ett tal b: ");
        //    b = Convert.ToInt32(Console.ReadLine());
        //    Console.WriteLine($"Tal a är {a} och tal b är {b}");
        //    c = a;
        //    a = b;
        //    b = c;
        //    Console.WriteLine($"Nu är tal a {a} och tal b är {b}");

        //}

        //7. Skapa ett program som låter användaren mata in sin ålder
        //8. Skriv ut hur många år det är till pension
        //9. Fråga användaren om man vill spola fram tiden till pension
        //10. Om användaren svarar "Ja" så sätter vi programmet i en loop och ökar värdet år för år tills att personen är 65
        //11. Vid 65 ska användaren få bestämma om de vill stanna kvar på den åldern eller spola tillbaks tiden
        //12. Presentera dessa val i form av en meny med writeline. "1.Jag vill stanna på denna ålder" eller "2. Jag ångrar mig! Ta mig tillbaks!"
        //13. Väljer användaren 1 så skriver programmet ut något passande och avslutas
        //14. Väljer användaren 2 så startar loopen om men dekrementerar värdet år efter år istället.Denna loop ska fortsätta tills att åldern är lika med ursprungsåldern.
        //15. Skriv något passande och avsluta programmet
        static void Main(string[] args)
        {
            int pension = 65;
            Console.WriteLine("Skriv in din ålder: ");
            int age = Convert.ToInt32(Console.ReadLine());
            int age2 = age;
            Console.WriteLine("Vill du spola fram till pension?");
            Console.WriteLine("1. Yes: ");
            Console.WriteLine("2. No: ");
            int answer = Convert.ToInt32(Console.ReadLine());

            if (answer == 1)
            {
                for (int i = age; i <= pension; i++)
                {
                    Console.WriteLine(age++);
                }
                Console.ReadLine();
                Console.Clear();
                Console.WriteLine($"Du är nu {age -1} år gammal och redo för pension");
                Console.WriteLine("Vill du vara pensionär eller spola tillbaks tiden igen?");
                Console.WriteLine("1. Yes: ");
                Console.WriteLine("2. No: ");
                int answer2 = Convert.ToInt32(Console.ReadLine());

                if (answer2 == 1)
                {
                    for (int i = age; i >= age2 ; i--)
                    {
                        Console.WriteLine(age--);
                    }
                    Console.ReadLine();
                    Console.Clear();
                    Console.WriteLine($"Du är nu {age + 1} år gammal igen!");
                }
                if (answer2 == 2)
                {
                    Console.WriteLine("Ha en trevlig pension!");
                }
                
            }
            if (answer == 2)
            {
                Console.WriteLine("Slipp då tråkmåns.");
            }
            Console.WriteLine("Programmet avslutas!");
            Console.ReadLine();
        }
    }
    
}
