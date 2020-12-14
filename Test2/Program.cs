using System;

namespace Test2
{
    class Program
    {
        static void Main(string[] args)
        {
            //Skapa en lista och sen populera den med heltal. Därefter skall vi räkna antalet
            //jämna och ojämna tal
            int antalJämnaTal = CheckIfNumbersAreEven();

            Console.WriteLine("Total jämna tal är {0}", antalJämnaTal);

        }

        static int CheckIfNumbersAreEven()
        {
            int size;
            int even;
            int odd;

            Console.Write("Enter the size of the Array: ");
            size = Convert.ToInt32(Console.ReadLine());

            int[] myArrayOfNumbers = new int[size];

            for (int i = 0; i < size; i++)
            {
                Console.Write("Number( {0} ); ", i + 1);
                myArrayOfNumbers[i] = Convert.ToInt32(Console.ReadLine());
            }

            even = 0;
            odd = 0;

            for (int i = 0; i < size; i++)
            {
                if (myArrayOfNumbers[i] % 2 == 0)
                {
                    even++;
                }
                else
                {
                    odd++;
                }
            }

            Console.WriteLine("Total even elements: {0}", even);
            Console.WriteLine("Total odd elements: {0}", odd);

            Console.ReadLine();

            return even;
        }
    }
}
