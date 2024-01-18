using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Knihovnicka;

namespace OvereniHesla
{
    [TestClass]
    public class UnitTest1
    {

        [TestMethod]
        public void JmenoMocDlouhe_Pos()
        {
            HerniPostava postava = new HerniPostava("Sardokan12345");
            Assert.IsTrue(postava.jmeno.Length >= 10);
        }

        [TestMethod]
        public void JmenoMocDlouhe_Neg()
        {
            HerniPostava postava = new HerniPostava("Sardokan12345");
            Assert.IsFalse(postava.jmeno.Length >= 10);
        }

        [TestMethod]
        public void ZmenaPozice_Pos()
        {
            HerniPostava postava = new HerniPostava("Sardokan");
            postava.ZmenaPozice(5, 10);
            Assert.AreEqual(5, postava.poziceX); 
            Assert.AreEqual(10, postava.poziceY);
        }

        [TestMethod]
        public void ZmenaPozice_Neg()
        {
            HerniPostava postava = new HerniPostava("Sardokan");
            postava.ZmenaPozice(5, 10);
            Assert.AreNotEqual(5, postava.poziceX);
            Assert.AreNotEqual(10, postava.poziceY);
        }

        [TestMethod]
        public void ToStringHerniPostava_Pos()
        {
            HerniPostava postava = new HerniPostava("Sardokan");
            string ocekavanyText = "Jmeno: Sardokan, Level: 1, Pozice X: 0, Pozice Y: 0";
            Assert.AreEqual(ocekavanyText, postava.ToString()); 
        }

        [TestMethod]
        public void ToStringHerniPostava_Neg()
        {
            HerniPostava postava = new HerniPostava("Sardokan");
            string ocekavanyText = "Spatna odpoved";
            Assert.AreNotEqual(ocekavanyText, postava.ToString());
        }

        [TestMethod]
        public void PridaniXP_Pos()
        {
            Hráč hráč = new Hráč("Sardokan", Specializace.Kouzelník, Oblicej.VelkýNos, Vlasy.Drdol, BarvaVlasu.Kaštanová);
            hráč.PřidejXP(150);
            Assert.AreEqual(150, hráč.XP);
            Assert.AreEqual(2, hráč.level); 
        }

        [TestMethod]
        public void PridaniXP_Neg()
        {
            Hráč hráč = new Hráč("Sardokan", Specializace.Kouzelník, Oblicej.VelkýNos, Vlasy.Drdol, BarvaVlasu.Kaštanová);
            hráč.PřidejXP(150); 
            Assert.AreNotEqual(150, hráč.XP);
            Assert.AreNotEqual(2, hráč.level);
        }

        [TestMethod]
        public void ToStringHrac_Pos()
        {
            Hráč hráč = new Hráč("Sardokan", Specializace.Kouzelník, Oblicej.VelkýNos, Vlasy.Drdol, BarvaVlasu.Kaštanová);
            string ocekavanyText = "Jmeno: Sardokan\nLevel: 1\nPozice X: 0\nPozice Y: 0\nSpecializace: Kouzelník\nOblicej: VelkýNos\nVlasy: Drdol\nBarva vlasu: Kaštanová\nXP: 0";
            Assert.AreEqual(ocekavanyText, hráč.ToString());
        }

        [TestMethod]
        public void ToStringHrac_Neg()
        {
            Hráč hráč = new Hráč("Sardokan", Specializace.Kouzelník, Oblicej.VelkýNos, Vlasy.Drdol, BarvaVlasu.Kaštanová);
            string ocekavanyText = "Spatna odpoved";
            Assert.AreNotEqual(ocekavanyText, hráč.ToString());
        }

        [TestMethod]
        public void NPCPrace_Pos()
        {
            NPC npc = new NPC("Obchodník", Prace.Obchodník);
            Assert.AreEqual(Prace.Obchodník, npc.Prace);
        }

        [TestMethod]
        public void NPCPrace_Neg()
        {
            NPC npc = new NPC("Zednik", Prace.Obchodník);
            Assert.AreNotEqual(Prace.Obchodník, npc.Prace);
        }

        [TestMethod]
        public void NPCJeBoss_Pos()
        {
            NPC npc = new NPC("Boss", Prace.Nepřítel, true);
            Assert.IsTrue(npc.JeBoss);
        }

        [TestMethod]
        public void NPCJeBoss_Neg()
        {
            NPC npc = new NPC("Nepřítel", Prace.Nepřítel, false);
            Assert.IsTrue(npc.JeBoss);
        }

        [TestMethod]
        public void ToStringNPC_Pos()
        {
            NPC npc = new NPC("Obchodník", Prace.Obchodník);
            string ocekavanyText = "Jmeno: Obchodník\nLevel: 1\nPozice X: 0\nPozice Y: 0\nPráce: Obchodník\nJe BOSS: False\n";
            Assert.AreEqual(ocekavanyText, npc.ToString());
        }

        [TestMethod]
        public void ToStringNPC_Neg()
        {
            NPC npc = new NPC("Obchodník", Prace.Obchodník);
            string ocekavanyText = "Spatna odpoved";
            Assert.AreNotEqual(ocekavanyText, npc.ToString());
        }
    }
}