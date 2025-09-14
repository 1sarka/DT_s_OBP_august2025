using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Verein
{
    internal class Manchaft
    {
        //private string motto; //pre neaktualizovatelnu veziu
        //motto aktualizovatelna verzia 
        public string Motto {  get; set; } 

        private List<Fieldspieler> fieldspielerLis = new List<Fieldspieler> (); //du schreibst ja auch nicht anzahl --- --keine klasse Wut und methode Wut ist nicht gut gibt abzug unotige werschachtelung 
        private List<Catcher> catchers = new List<Catcher>(); //List typu(datatypu) 

        //exeption -- konte problem mit lhere manchaft losen --> co to je? nastudovat
        public Manchaft(string motto, List<string> namenFeldspieler, List<string> namenCatcher)
        {
            Motto = motto;

            if (namenFeldspieler.Count < 10)
            {
                Console.WriteLine("exeption - die mindestanzahl feldspieler fur eine mannschaft betrag 10.");
            }
            else
            {
                if(namenCatcher.Count < 1)
                {
                    Console.WriteLine("fasche eingabe ... mindistence eine torwart muss eingegeben ist");
                }
            }
        }

        public void AddFieldSpieler()
        {

        }
    }
}
