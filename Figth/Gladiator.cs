using System;
using System.Collections.Generic;
using System.Text;
using Lexicon.CSharp.InfoGenerator;

namespace Figth
{
    class Gladiator
    {
        static InfoGenerator info = new InfoGenerator(DateTime.Now.Millisecond);//slumpar fram från infogenerator per milisekund så de inte ska va stor chans för samma 
        public List<Battle> history;// publik class där en lista från battle görs och hämtar historik
        string name;//deklarerar en variblen av typ string o ger namnet name
        public string Name { get { return name; } private set { name = value; } }//gör en public sträng där man kan hämta o sätta mane sedan en private där man kan se name värdet denna sista för gladaiatorn och den första för spelaren
        int strength;//deklarerar en int variabel
        int health;//samma som ovan
        int damage;
        public int Health// samma som ovan men gör den public för alla
        {
            get { return health; } //ger datorn möjlighet att hämta från health och även ändra i denna varibeln
            set//sätter den sedan
            {
                if (value <= 0)//om value är mindre eller lika med 0
                {
                    Alive = false;//sätter allive till false
                }
                health = value;//sätter hälsan till värdet
            }
        }
        public bool Alive { get; private set; }//gör en boolean med namnet Alive som men kan hämta men sätta nytt värde är privat

        public Gladiator()
        {
            name = info.NextFullName();//slumpar namn på motståndare
            strength = info.Next(1, 10);//slumpar strength
            health = info.Next(1, 10); //slumpar health
            damage = info.Next(1, 10);//slumpar damage
            Alive = true;
        }

        public Gladiator(string name) : this()//class Gladiator med typen string
        {
            this.name = name;//detta namnet sätt till namn
            history = new List<Battle>();//gör en lista på historiken
        }

        public void Info()//gör en class som heter info
        {
            Console.WriteLine("Name" + "" + name);//skriver ut texten Name sen varibeln name
            Console.WriteLine("strengt" + "" + strength);// samma som ovan fast Strength
            Console.WriteLine("damage" + "" + damage);//som ovan på Dammage
            Console.WriteLine("Health" + "" + health + "\n");//som ovan med health sen \n är för radbrytning
          
        }


    }
}
  

