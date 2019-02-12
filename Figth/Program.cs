using System;
using System.Collections.Generic;
using Lexicon.CSharp.InfoGenerator;

namespace Figth
{
    class Program
    {
        public static int list { get; private set; }//gör en lista som interger där man kan se vad som finns men skriva dit något är privat

        static void Main(string[] args)
        {

            string Name;// deklarerar en varibel av typ string som heter Name
            string newgame; //samma som ovan men namnet newgame
            bool keepalive; //deklarar en boolean variabel med namn keepaliver denna kan bara ge true och false
            List<string> Score = new List<string>();//gör en lista av typen string som heter score



            //du skriver in namnet på din Gladiator
            Console.WriteLine("Write your name\n");

            Name = Console.ReadLine();//de du skrev in hamnar i variabeln Name
            Gladiator me = new Gladiator(Name);//gör en ny gladiator med namnet me

            //motståndare samma som oven annars
            Gladiator enamy = new Gladiator();


            keepalive = true;//keepalive sätts till true
            while (keepalive)//loop medan keepalive är true
            {
                Battle battle = new Battle(me, enamy);// gör en ny class som heter battle med me och enamy inplemeras
                bool playerWin = battle.StartBattle(); // boolean variablen playerWin är lika med metthoden battle.startbattle n 

                if (playerWin)// om playerWin=true
                {
                    Console.WriteLine("type Y to hunt for more enemys.");//tryck y om du vill få en ny moståndare detta kommer när motståndaren har förlorat
                    newgame = Console.ReadLine(); //föregående rad läst in och läggs i variablen newgame
                }
                else//annars
                {
                    newgame = "no";//newgame sätts till no
                }


                if (newgame.ToUpper() == "Y")//om newgame får lnappen tryck y och toupper gör att om man skriver liten bokstav gör denna om de till stor
                {
                    enamy = new Gladiator();//gör en ny motståndare
                }
                else//annars
                {
                    keepalive = false;//sätter keepalive till false
                    Console.WriteLine("History");//skriver ut History
                    foreach (Battle item in me.history)//skriver ut historiken från me
                    {
                        Console.WriteLine(item);//skriver ut item alltså resultat
                    }
                }

            }

            Console.WriteLine("End of program, press any key to exit.");//säger till att man ska trycka på en tangent för att avsluta
            Console.ReadKey(true);//sätter så knapptrycket ej syns på skärmen men de är här de tass emot så datorn reagaerar
        }

    }


}







