using System;
using System.Collections.Generic;

namespace Test3
{
    class Program
    {
        static void Main(string[] args)
        {
            //Skapa en metod som tar in två heltal och returnerar summan av detta.
            //Därefter skall summan divideras i en annan metod med 2 och returneras.
            //Detta skall ske 5 gånger och resultat läggs till i en lista.
            //Printa ut array/lista
            //int result, mySum;
            List<int> myList = new List<int>();

            //for (int i = 0; i < 5; i++)
            //{
            //    result = AddTwoNumbers();
            //    mySum = DivSum(result);
            //    myList.Add(mySum);
            //}
            //Console.WriteLine(string.Join(",", myList));
            for (int i = 0; i < 3; i++)
            {
                myList.Add(Calculation());
                
            }
            Console.WriteLine(myList);

        }

        //Metoden för att addera två tal
        static int AddTwoNumbers(int number1, int number2)
        {
            return number1 + number2;
        }

        //Metoden för dividera ett tal med 2
        static int DivSum(int a)
        {
            return a / 2;
        }

       
        static int Calculation()
        {
            int input1, input2;

            Console.WriteLine("Mata in två heltal.");
            Console.Write("Mata in det första talet: ");
            input1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Mata in det andra talet: ");
            input2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Summan av dessa tal är {0}", AddTwoNumbers(input1, input2));
            Console.WriteLine("Kvoten med 2 är {0}", DivSum(AddTwoNumbers(input1, input2)));
            return DivSum(AddTwoNumbers(input1, input2));
        }

        ////Metoden för att skapa en lista av heltal
        //static void CreateList(int x)
        //{
        //    List<int> myList = new List<int>();
        //    myList.Add(x);
        //}
    }
}
