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
            string namn;
            string namn1;
            string whatToDo;
                 
            Random rnd = new Random();
            namn = info.NextFullName();//slumpar namn på motståndare
            int strength = rnd.Next(1, 10);//slumpar strength
            int health = rnd.Next(1, 10); //slumpar health
            int damage = rnd.Next(1, 10);//slumpar damage

            Random rnd1 = new Random();
            namn = info.NextFullName();//slumpar fram moståndar namn från lexicon.charp.infogenerator
            int strength1 = rnd.Next(1, 6);
            
            int damage1 = rnd.Next(1, 10);

            Console.WriteLine("Your name!");
            namn1 = Console.ReadLine();

            //player1
           
            Console.WriteLine(namn1);
            Console.WriteLine("Strength" + " " + strength);
            Console.WriteLine("Health" + " " + health);
            Console.WriteLine("Damage" + " " + damage);

            Console.WriteLine("What will you do?\nH-Hit a player\nR-retrie");
            whatToDo = Console.ReadLine();

            //Result
            Console.WriteLine("your damage is" + " " + damage1+" "+"and"+" "+namn+" "+"is"+" "+damage);
            Console.ReadLine();
            
        
            }
    }
}


   

