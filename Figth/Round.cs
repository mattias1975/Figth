using System;
using System.Collections.Generic;
using System.Text;

namespace Figth
{
    class Round
    {     
        static Random random = new Random();

        Gladiator me;

        //motståndare
        Gladiator enamy;
        public Round(Gladiator me, Gladiator enamy) //ger en publik Round metod alltså kan alla se den och hämtar me och enamy från galdiator
        {
            this.me = me; //gör en me variabel från denna me
            this.enamy = enamy;// somma som ovan fast enamy
            int meDice = random.Next(1, 6);//ger meDice ett slumtal mellan 1-6
            int enamyDice = random.Next(1, 6);// samma som ovan

            if (meDice > enamyDice)//If satts om MeDice är större än enamyDice
            {
                enamy.Health--;//minskar enamy.health genom -- är -

                Console.WriteLine(me.Name + " hits " + enamy.Name + ", remaning health is " + enamy.Health);//skriver me.name och strängen hits plus Enamy.Name+ Remaning health + enamy.health som text i comsole

            }



            else if (meDice < enamyDice)//annars om EnamyDice är större än meDice
            {
                me.Health--;
                Console.WriteLine(enamy.Name + " hits " + me.Name + ", remaning health is " + me.Health);//skriver ut enamy.name+hits+me.name+reaming health som en sträng alltså me.health skriver me´s hälsa oo samma för enamy för att visa ja vet
            }
            Console.ReadKey(true);//readkey blir true för att slippa se den på skärmen

        }

        
    }
    
}
