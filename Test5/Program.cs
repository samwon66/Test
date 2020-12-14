using System;
using System.Collections.Generic;

namespace Test5
{
    class Program
    {
        static void Main(string[] args)
        {
            //1. Första hjälte, osmidigt
            SuperHero Batman = new SuperHero();
            //Kalla på property Name, specifikt SET metoden
            Batman.Name = "Bruce Wayne";
            Batman.BattleType = "Melee";

            
            //2.
            SuperHero GreenArrow = new SuperHero("Oliver Queen", "Ranged");
            
            //3.
            SuperHero SpiderMan = new SuperHero("Peter Parker", "Mixed");
            
            List<SuperHero> listOfHeroes = new List<SuperHero>() { Batman, GreenArrow, SpiderMan };

            foreach (var hero in listOfHeroes)
            {
                Console.WriteLine($"{hero.Name} is of the type {hero.BattleType}");
            }


            //1. Första skurken
            SuperVillian LexLuthor = new SuperVillian();
            LexLuthor.Name = "lex Luthor";
            LexLuthor.BattleType = "Money";

            //2.
            SuperVillian PosionIvy = new SuperVillian("Dr. Pamela Lillian Isley", "Toxic");

            //3.
            SuperVillian Magneto = new SuperVillian("Erik Lehnsherr", "Ranged/Magnetic");

            List<SuperVillian> listOfSkurkar = new List<SuperVillian>() { LexLuthor, PosionIvy, Magneto };

            foreach (SuperVillian skurk in listOfSkurkar)
            {
                Console.WriteLine($"{skurk.Name} is of the type {skurk.BattleType}");
            }
            



        }

    }

    //Basklass för SuperHero och SuperVillian
    class SuperHuman
    {
        //Fält
        private string name;
        private string battleType;

        //Constructor
        public SuperHuman()
        {

        }

        public SuperHuman(string name, string battleType)
        {
            this.name = name;
            this.battleType = battleType;
        }

        //Property
        public string Name
        {
            get
            {
                return name;
            }

            set
            {
                name = value;
            }
        }

        public string BattleType
        {
            get
            {
                return battleType;
            }

            set
            {
                battleType = value;
            }
        }

    }

    class SuperHero : SuperHuman
    {
        private string theReasonWhy;

        public SuperHero()
        {

        }

        //Konstruktor        
        public SuperHero(string name, string battleType)
        {
            this.Name = name;
            this.BattleType = battleType;

        }


        

    }

    class SuperVillian : SuperHuman
    {
        private int powerLevel;


        public SuperVillian()
        {

        }
        
        public SuperVillian(string name, string battleType)
        {
            this.Name = name;
            this.BattleType = battleType;
        }
        
    }


}
