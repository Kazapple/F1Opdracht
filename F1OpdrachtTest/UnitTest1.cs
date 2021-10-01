using Microsoft.VisualStudio.TestTools.UnitTesting;
using F1OpdrachtLibrary;

namespace F1OpdrachtTest
{
    [TestClass]
    public class UnitTest1
    {
        Raceklasse raceklasse;
        Seizoen seizoen;
        RaceTeam raceTeam;

        [TestInitialize]
        public void Setup()
        {
            raceklasse = new Raceklasse();
            seizoen = new Seizoen();
            raceTeam = new RaceTeam();
        }
        [TestMethod]
        public void TestMethod1()
        {
            raceklasse.Naam = "F1";
            Assert.AreEqual("F1", raceklasse.Naam);

            seizoen.Aantalraces = 4;
            Assert.AreEqual(4, seizoen.Aantalraces);

            raceTeam.Actief = true;
            Assert.AreEqual(true, raceTeam.Actief);
        }

        [TestMethod]
        public void TestMethod2()
        {
            raceklasse.SeizoenList.Add(seizoen);
            Assert.IsTrue(raceklasse.SeizoenList.Contains(seizoen));

            raceklasse.SeizoenList.Remove(seizoen);
            Assert.IsFalse(raceklasse.SeizoenList.Contains(seizoen));

            raceTeam.RaceklasseList.Add(raceklasse);
            Assert.IsTrue(raceTeam.RaceklasseList.Contains(raceklasse));

            raceTeam.RaceklasseList.Remove(raceklasse);
            Assert.IsFalse(raceTeam.RaceklasseList.Contains(raceklasse));

            seizoen.RaceTeamList.Add(raceTeam);
            Assert.IsTrue(seizoen.RaceTeamList.Contains(raceTeam));

            seizoen.RaceTeamList.Remove(raceTeam);
            Assert.IsFalse(seizoen.RaceTeamList.Contains(raceTeam));
        }
    }
}
