using System;

namespace Test
{
    class Program
    {
        
        static void Main(string[] args)
        {

            bool keepPlaying = true;


            while (keepPlaying)
            {
                WelcomeMenu();

                string decision = Console.ReadLine();
                int choice = Convert.ToInt32(decision);

                if (choice == 1)
                {
                    Console.WriteLine(AddTwoNumbers());
                }
                else if (choice == 2)
                {
                    Console.WriteLine(SubTwoNumbers());
                }
                else if (choice == 3)
                {
                   keepPlaying = EndProgram();
                }

            }

        }

        static void WelcomeMenu()
        {
            Console.WriteLine("Völkommen till miniräknare");
            Console.WriteLine("Vad vill du göra");
            Console.WriteLine("1. Addera två tal");
            Console.WriteLine("2. Subtrahera två tal");
            Console.WriteLine("3. Avsluta programmet");
        }

        static bool EndProgram()
        {
            Console.WriteLine("Tack och hej. Du valde att avsluta.");
            return false;
        }

        static int SubTwoNumbers()
        {
            Console.WriteLine("Du valde 2");
            Console.WriteLine("Skriv in det första talet");
            string first = Console.ReadLine();
            Console.WriteLine("Skriv in det andra talet");
            string second = Console.ReadLine();

            int x = Convert.ToInt32(first);
            int y = Convert.ToInt32(second);

            return x - y;
        }

        static int AddTwoNumbers()
        {
            Console.WriteLine("Du valde 1");
            Console.WriteLine("Skriv in det första talet");
            string first = Console.ReadLine();
            Console.WriteLine("Skriv in det andra talet");
            string second = Console.ReadLine();

            int x = Convert.ToInt32(first);
            int y = Convert.ToInt32(second);
            
            return x + y;
        }

    }
}
