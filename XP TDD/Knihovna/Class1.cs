using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Knihovna
{
    public enum Specializace
    {
        Kouzelník,
        Berserker,
        Inženýr,
        Cizák
    }

    public enum Oblicej
    {
        VelkýNos,
        Ušoplesk,
        Makeup
    }

    public enum Vlasy
    {
        Drdol,
        Culík,
        Pleška
    }

    public enum BarvaVlasu
    {
        Kaštanová,
        Blond,
        Červená
    }

    public enum Prace
    {
        Obchodník,
        Nepřítel,
        Obyvatel
    }

    public class HerniPostava
    {
        private string jmeno;

        public int LVL { get; protected set; }
        public int PoziceX { get; private set; }
        public int PoziceY { get; private set; }

        public HerniPostava(string jmeno)
        {
            Jmeno = jmeno;
            LVL = 1;
            PoziceX = 0;
            PoziceY = 0;
        }

        public string Jmeno
        {
            get { return jmeno; }
            set
            {
                if (value.Length <= 10)
                {
                    jmeno = value;
                }
            }
        }

        public virtual void ZmenaPozice(int novaX, int novaY)
        {
            PoziceX = novaX;
            PoziceY = novaY;
        }

        public override string ToString()
        {
            return "Hráč: " + "\nJméno: " + jmeno + "\nLevel: " + LVL + "\nPozice: " + PoziceX + ", " + PoziceY;
        }
    }

    public class Hrac : HerniPostava
    {
        public Specializace Specializace { get; set; }
        public Oblicej oblicej;
        public Vlasy vlasy;
        public BarvaVlasu barvaVlasu;
        public int XP { get; private set; }
        private int celkemXP;

        public Hrac(string jmeno, Specializace specializace, Oblicej oblicej, Vlasy vlasy, BarvaVlasu barvaVlasu): base(jmeno)
        {
            Specializace = specializace;
            this.oblicej = oblicej;
            this.vlasy = vlasy;
            this.barvaVlasu = barvaVlasu;
            XP = 0;
            celkemXP = 0;
        }

        public void PridejXP(int hodnota)
        {
            XP += hodnota;
            celkemXP += hodnota;
            while (XP >= 100 * LVL)
            {
                XP -= 100 * LVL;
                LVL++;
            }
        }

        public override string ToString()
        {
            return base.ToString() + "\nSpecializace: " + Specializace + "\nXP: " + celkemXP;
        }
    }

    public class NPC : HerniPostava
    {
        public Prace Prace { get; private set; }
        public bool JeBoss { get; private set; }
        public string NpcJmeno { get; set; }

        public NPC(string jmeno, Prace prace, bool jeBoss = false) : base(jmeno)
        {
            Prace = prace;
            JeBoss = jeBoss;
            NpcJmeno = jmeno;
        }

        public override string ToString()
        {
            return "\nNPC: " + "\nJméno: " + NpcJmeno + "\nPráce: " + Prace + "\nJeBoss: " + JeBoss;
        }
    }
}
