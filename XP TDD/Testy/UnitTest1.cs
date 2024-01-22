using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Knihovna;

namespace Testy
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void HerniPostavaLevel_Positive()
        {
            HerniPostava tonda = new HerniPostava("Hrac1");
            Assert.AreEqual(1, tonda.LVL);
        }

        [TestMethod]
        public void HerniPostavaLevel_Negative()
        {
            HerniPostava tonda = new HerniPostava("Hrac1");
            Assert.AreNotEqual(1, tonda.LVL);
        }

        [TestMethod]
        public void HerniPostavaZmenaPozice_Positive()
        {
            HerniPostava postava = new HerniPostava("Hrac1");
            postava.ZmenaPozice(17, 4);
            Assert.AreEqual(17, postava.PoziceX);
            Assert.AreEqual(4, postava.PoziceY);
        }

        [TestMethod]
        public void HerniPostavaZmenaPozice_Negative()
        {
            HerniPostava postava = new HerniPostava("Hrac1");
            postava.ZmenaPozice(17, 4);
            Assert.AreNotEqual(17, postava.PoziceX);
            Assert.AreNotEqual(4, postava.PoziceY);
        }

        [TestMethod]
        public void HerniPostavaMetodaToString_Positive()
        {
            HerniPostava postava = new HerniPostava("Hrac1");
            Assert.AreEqual("Jmeno: Testovaci, Level: 1, Pozice: (0, 0)", postava.ToString());
        }

        [TestMethod]
        public void HerniPostavaMetodaToString_Negative()
        {
            HerniPostava postava = new HerniPostava("Hrac1");
            Assert.AreEqual("NecoJineho", postava.ToString());
        }

        [TestMethod]
        public void HracPridaniXP_Positive()
        {
            Hrac hrac = new Hrac("Hrac1", Specializace.Kouzelník, Oblicej.VelkýNos, Vlasy.Drdol, BarvaVlasu.Kaštanová);
            hrac.PridejXP(150);
            Assert.AreEqual(150, hrac.XP);
            Assert.AreEqual(2, hrac.LVL);
        }

        [TestMethod]
        public void HracPridaniXP_Negative()
        {
            Hrac hrac = new Hrac("Hrac1", Specializace.Kouzelník, Oblicej.VelkýNos, Vlasy.Drdol, BarvaVlasu.Kaštanová);
            hrac.PridejXP(150);
            Assert.AreNotEqual(150, hrac.XP);
            Assert.AreNotEqual(2, hrac.LVL);
        }

        [TestMethod]
        public void HracMetodaToString_Positive()
        {
            Hrac hrac = new Hrac("Hrac1", Specializace.Kouzelník, Oblicej.VelkýNos, Vlasy.Drdol, BarvaVlasu.Kaštanová);
            Assert.AreEqual("Jmeno: Hrac1, Level: 1, Pozice: (0, 0), Specializace: Kouzelník, XP: 0", hrac.ToString());
        }

        [TestMethod]
        public void HracMetodaToString_Negative()
        {
            Hrac hrac = new Hrac("Hrac1", Specializace.Kouzelník, Oblicej.VelkýNos, Vlasy.Drdol, BarvaVlasu.Kaštanová);
            Assert.AreEqual("NecoJineho", hrac.ToString());
        }

        [TestMethod]
        public void NPCZmenaPozice_Positive()
        {
            NPC npc = new NPC("Obchodnik", Prace.Obchodník);
            npc.ZmenaPozice(8, 4);
            Assert.AreEqual(8, npc.PoziceX);
            Assert.AreEqual(4, npc.PoziceY);
        }

        [TestMethod]
        public void NPCZmenaPozice_Negative()
        {
            NPC npc = new NPC("Obchodnik", Prace.Obchodník);
            npc.ZmenaPozice(8, 4);
            Assert.AreNotEqual(8, npc.PoziceX);
            Assert.AreNotEqual(4, npc.PoziceY);
        }

        [TestMethod]
        public void NPCMetodaToString_Positive()
        {
            NPC npc = new NPC("Obchodnik", Prace.Obchodník, true);
            Assert.AreEqual("Jmeno: Obchodnik, Level: 1, Pozice: (0, 0), Prace: Obchodník, JeBoss: True", npc.ToString());
        }

        [TestMethod]
        public void NPCMetodaToString_Negative()
        {
            NPC npc = new NPC("Obchodnik", Prace.Obchodník, true);
            Assert.AreNotEqual("NecoJineho", npc.ToString());
        }

        [TestMethod]
        public void NPCInstancovanibezsilyneniBOSS_Positive()
        {
            NPC npc = new NPC("Obyvatel", Prace.Obyvatel);
            Assert.IsFalse(npc.JeBoss);
        }

        [TestMethod]
        public void InstancovanissiloujeBOSS_Negative()
        {
            NPC npc = new NPC("NepřítelBOSS", Prace.Nepřítel, true);
            Assert.IsTrue(npc.JeBoss);
        }

        [TestMethod]
        public void HracvsNPC_Positive()
        {
            Hrac hrac = new Hrac("Hrac1", Specializace.Kouzelník, Oblicej.VelkýNos, Vlasy.Drdol, BarvaVlasu.Kaštanová);
            NPC npc = new NPC("Nepřítel", Prace.Nepřítel, false);

            Assert.AreNotEqual(hrac.ToString(), npc.ToString());
        }

        [TestMethod]
        public void HracvsNPC_Negative()
        {
            Hrac hrac = new Hrac("Hrac1", Specializace.Kouzelník, Oblicej.VelkýNos, Vlasy.Drdol, BarvaVlasu.Kaštanová);
            NPC npc = new NPC("Nepřítel", Prace.Nepřítel, false);

            Assert.AreEqual(hrac.ToString(), npc.ToString());
        }
    }
}
