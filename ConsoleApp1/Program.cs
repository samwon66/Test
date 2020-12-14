using System;
using System.Collections.Generic;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             13. Med hjälp av lika funktioner som listan har inbyggd, kolla om en lista med strings innehåller
                 en specifik text
             14. Skapa upp tre listor av typen int. Två av listorna skall innehålla unika heltal och den
                 tredje skall vara lista1 + lista2.
             15. Skriv ut hela innehåller på listan med , som separera de olika talen.
             16. Skriv ut medelvärdet av alla tal i lista3
             17. Kolla hur många av talen som är jämna
             18. Skapa en fjärde lista som innehåller alla dessa värden
             19. Printa ut listan med en Do while
             */

            //Fel på Modulus rad 39.
            int i = 0;
            List<int> one = new List<int>() { 1, 3, 5, 7, 9 };
            List<int> two = new List<int>() { 2, 4, 6, 8, 10 };
            List<int> three = new List<int>();
            List<int> four = new List<int>();

            one.AddRange(two);
            three.AddRange(one);
            Console.WriteLine(string.Join(", ", three));

            //int avarage = three.Sum() / three.Count();
            int sum = 0;
            for (i = 0; i < three.Count; i++)
            {
                sum = sum + three[i];
                  
            }
            int average = sum / three.Count;
            Console.WriteLine(average);

            for (i = 0; i < three.Count; i++)
            {
                if (three[i] % 2 == 0)
                {
                    four.Add(three[i]);//Varför läggs endast tal 5,6,7,8, 9 till här, när 2, 4, 6, 8, 10 borde läggas till?
                }
                else
                {
                }
            }
            i = 0;
            do
            {

                Console.WriteLine("Even numbers {0}", four[i]);
                i++;

            } while (i < four.Count);





        }
    }
}
