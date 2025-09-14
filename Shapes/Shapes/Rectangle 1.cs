using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


   

public class Rectangle_1this
{
    public Rectangle_1this()
    {
        this.Rectangle_1
    }
}

namespace Shapes
{
  
    internal class Rectangle_1
    {
        // konstruktory 
        public Rectangle_1(int seiteA, int seiteB)
        {
            this.seiteA = seiteA;
            this.seiteB = seiteB;
        }

        //1 read only eingenschaft - only get
        private int _sideA;
        public int SideA()
        {
            return _sideA;
        }

        //2 read and write - get and set
        private int _sideB;
        public int SideB()
        {
            return _sideB;
        }
        public void SetSideB(int sideB)
        {
            this._sideB = sideB;
        }

        //3 write only - only set
        private Color _color;
        public void SetColor(Color color)
        {
            this._color = color;
        }

        //4 read only automatish
        private int _linieThicke = 2;
        public int LinieThicke { get; }

        //5 read write automatish
        private string _name;
        public string Name { get; set; }

        //6 write only automatisch (mit kondition)
        //!!!!! automatis == ak napisem iba set alebo get a nic k tomu == tato uloha nedava ziadny zmysel
        //moj kod tu dole nie je automatisch
        private int _angel;
        public int Angel
        {
            set
            {
                if (value == 90 || value == 180)
                { this._angel = value; }
            }
        }
        //value - implizit wert ubergeben bei uns - 


    }
}
