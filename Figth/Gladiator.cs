using System;
using System.Collections.Generic;
using System.Text;
using Lexicon.CSharp.InfoGenerator;

namespace Figth
{
    class Gladiator
    {
        static InfoGenerator info = new InfoGenerator(DateTime.Now.Millisecond);
        string name;
        public string Name { get { return name; } private set { name = value; } }
        int strength;
        int health;
        int damage;
        public int Health { get { return health; }
            set {
                if (value <= 0)
                {
                    Alive = false;
                }
                health = value;
            }
        }
        public bool Alive { get; private set; }

        public Gladiator()
        {
            name = info.NextFullName();//slumpar namn på motståndare
            strength = info.Next(1, 10);//slumpar strength
            health = info.Next(1, 10); //slumpar health
            damage = info.Next(1, 10);//slumpar damage
            Alive = true;
        }

        public Gladiator(string name) : this()
        {
            this.name = name;
        }

        public void Info()
        {
            Console.WriteLine("Name" + "" + name);
            Console.WriteLine("strengt" + "" + strength);
            Console.WriteLine("damage" + "" + damage);
            Console.WriteLine("Health" + "" + health + "\n");
        }
    }
}
