using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Knihovnicka
{
    public enum Specializace
    {
        Kouzelník,
    }

    public enum Oblicej
    {
        VelkýNos
    }

    public enum Vlasy
    {
        Drdol
    }

    public enum BarvaVlasu
    {
        Kaštanová
    }

    public enum Prace
    {
        Obchodník,
        Nepřítel,
        Obyvatel
    }

    public class HerniPostava
    {
        public string jmeno;
        public int level;
        public int poziceX;
        public int poziceY;

        public HerniPostava(string jmeno)
        {
            this.jmeno = jmeno;
            level = 1;
            poziceX = 0;
            poziceY = 0;
        }

        public void ZmenaPozice(int novaX, int novaY)
        {
            poziceX = novaX;
            poziceY = novaY;
        }

        public override string ToString()
        {
            return "";
        }
    }

    public class Hráč : HerniPostava
    {
        public Specializace Specializace;
        private Oblicej obličej;
        private Vlasy vlasy;
        private BarvaVlasu barvaVlasu;
        public int XP;

        public Hráč(string jmeno, Specializace specializace, Oblicej obličej, Vlasy vlasy, BarvaVlasu barvaVlasu): base(jmeno)
        {
            Specializace = specializace;
            this.obličej = obličej;
            this.vlasy = vlasy;
            this.barvaVlasu = barvaVlasu;
            XP = 0;
        }

        public void PřidejXP(int hodnota)
        {
 
        }

        public override string ToString()
        {
            return "";
        }
    }

    public class NPC : HerniPostava
    {
        public Prace Prace;
        public bool JeBoss;

        public NPC(string jmeno, Prace prace) : base(jmeno)
        {
            Prace = prace;
            JeBoss = false;
        }

        public NPC(string jmeno, Prace prace, bool jeBoss) : base(jmeno)
        {
            Prace = prace;
            JeBoss = jeBoss;
        }

        /*public override void ZmenaPozice(int novaX, int novaY)
        {
            
        }*/

        public override string ToString()
        {
            return "";
        }
    }
}
