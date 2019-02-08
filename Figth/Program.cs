using System;
using Lexicon.CSharp.InfoGenerator;

namespace Figth
{
    class Program
    {
        static void Main(string[] args)
        {
            //skapar en spelar med random namn
            InfoGenerator info = new InfoGenerator(DateTime.Now.Millisecond);
            string Name;
            string Name1;
            Name1 = info.NextFullName();//slumpar namn på motståndare
            bool keepalive;

            Random rnd = new Random();

            int strength = rnd.Next(1, 10);//slumpar strength
            int health = rnd.Next(1, 10); //slumpar health
            int damage = rnd.Next(1, 10);//slumpar damage

            int strength1 = rnd.Next(1, 10);//slumpar strength
            int health1 = rnd.Next(1, 10); //slumpar health
            int damage1 = rnd.Next(1, 10);//slumpar damage

            //du

            

            Console.WriteLine("Write yout name\n");
            while (health<=0 || health1<=0) ;
            Name = Console.ReadLine();
          
            Console.WriteLine("strengt" + "" + strength);
            Console.WriteLine("damage" + "" + damage);
            Console.WriteLine("Health" + "" + health + "\n");


            //motståndare
            Console.WriteLine(Name1);
            Console.WriteLine("strengt" + strength1);
            Console.WriteLine("damage" + damage1);
            Console.WriteLine("Health" + health1);

            Console.ReadLine();
            health = health - damage1;
            health1 = health1 - damage;

            Console.WriteLine(Name+ "" + "Health is" + health+" "+"and"+""+Name1+""+ "is"+""+health1);
            Console.ReadLine();

            if (health <= 0)
                Console.WriteLine(Name + "" + " is dead");
            else if (health1 <= 0)
                Console.WriteLine(Name1 + "" + "is dead");


            




        }

    }
}




