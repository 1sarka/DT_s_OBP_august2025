using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Verein
{
    internal class Verein
    {
        private List<Manchaft> manchaftsListe = new List<Manchaft>();
        private Physioterapeutin physioterapeutin;
        public President president { get; private set; }
        public string Name {  get; set; }

        public Verein(string nameVerein, string NamePresident)
        {
            president = new President(NamePresident);
        }

        //nemusime manschaft tu erstellen lebo mame agregation a nie komposition --> manchaft kann auch ohne eine verein existiern
        public void AddManchaft(Manchaft manchaft)
            {
            if(manchaftsListe.Count < 10)
            {
                manchaftsListe.Add(manchaft);
            }
        }

        public void SetPhysio(Physioterapeutin physio)
        {
            physioterapeutin = physio;
        }
        
    }
}
