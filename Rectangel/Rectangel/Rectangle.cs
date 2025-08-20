using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rectangel
{
    internal class Rectangle
    {
        //rozdiely medzi private feld (potrebujem ho iba v klasse dnu) a property musi byt stale 
        // propertys macht sin wenn sie public seind - aber felder NIE
        public int Width; //properties are allways named with big letter and they are almost allways public
        public int Height;


       
        
        public int Width { get; set; }
        public int Height { get; set; }

        public int Area {
            get
            {
                return Width * Height;
            }
        }

        //expression bodied schreibweise
        public int Area => Width * Height; 
        //eine feld mit einem fur felder typischen zugriffsmodifizierer
        private string _nameRectangle = "namedef";

        //Ein Feld, dessen Wert während der Lebensdauer eines Objekts nicht verändert werden kann. Instanziieren Sie anschliessend ein Objekt der betreffenden Klasse und überprüfen Sie den Wert mit dem Debugger.

        private readonly int  seiteA = 5;
        // Ein Feld, für welches ein Standardwert zugewiesen wird.Instanziieren Sie anschliessend ein Objekt der betreffenden Klasse, weisen Sie dem Feld einen anderen Wert zu und beobachten Sie die Veränderung im Debugger.
        private Color _color = Color.White;

        /*
        //getter metode
        public int Width()
        {
            return width;
        }
        //setter methode
        public void SetWidth(int width)
        {
            this.width = width;
        }
        */

       // public int Width { get; private /*ichh kan es nur in klase bearbeiten */ set; }
       // wenn ich mochte nur eine ich kann es weglassen
       //public int Width { get; }


    }
}
