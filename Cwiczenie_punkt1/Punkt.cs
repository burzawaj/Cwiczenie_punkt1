using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cwiczenie_punkt1
{
    class Punkt
    {
        int wspX = 0;
        int wspY = 0;
        public Punkt(int xWsp, int yWsp)
        {
            wspX = xWsp;
            wspY = yWsp;
        }
        public int WSPX { get { return wspX; } }
        public int WSPY { get { return wspY; } }

        
        public void PrzesunWPrawo(int przesunX)
        {
            wspX = wspX + przesunX;
        }
        public void PrzesunWLewo(int przesunX)
        {
            wspX = wspX - przesunX;
        }
        public void PrzesunWGore(int przesunY)
        {
            wspY = wspY + przesunY;
        }
        public void PrzesunWDol(int przesunY)
        {
            wspY = wspY - przesunY;
        }
        /*public static Punkt operator +(Punkt MojPunkt1, Punkt MojPunkt2)
        {
            return new Punkt(MojPunkt1.xWsp + MojPunkt2.xWsp); 
        }*/
        

    }

}
