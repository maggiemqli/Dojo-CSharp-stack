using System;

namespace Human
{
    public class Human{
        public string name {get;set;}
        public int strength {get;set;} = 3;
        public int intelligence {get;set;} = 3;
        public int dexterity {get;set;} = 3;
        public int health {get;set;} = 100;

        public Human(string n){
            name = n;
        }

        public Human(string n, int s, int i, int d, int h){
            name = n;
            strength = s;
            intelligence = i;
            dexterity = d;
            health = h;
        }

        public void Attack(object opponent){
            Console.WriteLine(">>>Battle starts....");
            Human enemy = opponent as Human;
            enemy.health -= 5 * strength;
            Console.WriteLine(">>>Battle is finished.");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            Human Player1 = new Human("Joson");
            Human Player2 = new Human("Neil",10,10,10,100);
            Console.WriteLine("Player 1 : " + Player1.name);
            Console.WriteLine("Player 2 : " + Player2.name);
            Console.WriteLine("{0}'s full health : {1}", Player1.name, Player1.health);
            Console.WriteLine("{0}'s full health : {1}", Player2.name, Player2.health);
            Console.WriteLine("- {0} will attack {1}.", Player1.name, Player2.name);
            Player1.Attack(Player2);
            Console.WriteLine("{0}'s current health : {1}", Player1.name, Player1.health);
            Console.WriteLine("{0}'s current health : {1}", Player2.name, Player2.health);
        }
    }
}
