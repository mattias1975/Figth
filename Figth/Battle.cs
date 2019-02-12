using System;
using System.Collections.Generic;
using Lexicon.CSharp.InfoGenerator;

/*
 while (keepalive)
    {
        if (me.Alive && enamy.Alive) 
            new Round

 */

namespace Figth
{
    class Battle
    {
        //Spelare
        Gladiator me;

        //motståndare
        Gladiator enamy;

        public Battle(Gladiator me, Gladiator enamy)
        {
            this.me = me; //denna me lika med me alltså blir me spelare
            this.enamy = enamy;//denna motståndaren blir lika med enamy 
        }

        public bool StartBattle()//fighten startar
        {

            while (me.Alive && enamy.Alive)// medan me är Alive och enamy Alive
            {
                Round round = new Round(me,enamy);// startar en nu figt mellan me och enamy


            }
            me.history.Add(this);// spara history för denna me

            if (!me.Alive)// om inte me är Alive då ! är de samma som inte
            {


                Console.WriteLine(me.Name + " You are dead"); //skriver ut namnet på me plus strängen you are dead efter
             
                return false;// returnerar false alltså hoppar den ur loopen
            }
            else//ananrs
            {
                Console.WriteLine("Victory");//skriver ut Victory
                return true;//returnera true om spelaren van
            }
        }

        public override string ToString()//overide till strängen me.name till sträng och skriver till en sträng VS
            //sen gör enamy.Name till string och skriver strängen Winner ger sedan enamy.Alive ser vilken av enamy och me vinner och skriver ut vinnare
        {
            return me.Name + " VS. " + enamy.Name + ", Winner " + (enamy.Alive ? enamy.Name : me.Name);
        }
    }
}
