using System;
using System.Collections.Generic;
using Lexicon.CSharp.InfoGenerator;

namespace Figth
{
    class Program
    {
        public static int list { get; private set; }

        static void Main(string[] args)
        {

            string Name;
            string newgame;
            bool keepalive;



            //du
            Console.WriteLine("Write your name\n");

            Name = Console.ReadLine();
            Gladiator me = new Gladiator(Name);

            //motståndare
            Gladiator enamy = new Gladiator();


            keepalive = true;
            while (keepalive)

            {
                if (me.Alive && enamy.Alive)
                {
                    me.Health--;
                    enamy.Health--;
                    Console.WriteLine(me.Name + " " + "health is" + " " + me.Health + " " + enamy.Name + " helath is" + " " + enamy.Health);

                    Console.ReadKey();
                }
                else if (!me.Alive)
                {

                    Console.WriteLine(me.Name + "" + "You are dead");
                 
                    Console.ReadKey();
                    foreach(string streangth in Gladiator())
                        Console.Write($"{streangth});
                    keepalive = false;
                }
                else if (!enamy.Alive)
                {

                    Console.WriteLine(enamy.Name + "" + " is dead will you play again? y/n?");
                    newgame = Console.ReadLine();
                    if (newgame == "Y")
                        enamy = new Gladiator();
                    else
                        keepalive = false;

                }


            }

        }

        private static IEnumerable<object> Gladiator()
        {
            throw new NotImplementedException();
        }
    }

}







