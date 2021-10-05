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
        RaceklasseContainer raceklasseContainer;
        RaceTeamContainer raceTeamContainer;

        [TestInitialize]
        public void Setup()
        {
            raceklasse = new Raceklasse();
            seizoen = new Seizoen();
            raceTeam = new RaceTeam();
            raceklasseContainer = new RaceklasseContainer();
            raceTeamContainer = new RaceTeamContainer();
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

            raceklasseContainer.RaceklasseList.Add(raceklasse);
            Assert.IsTrue(raceklasseContainer.RaceklasseList.Contains(raceklasse));

            raceklasseContainer.RaceklasseList.Remove(raceklasse);
            Assert.IsFalse(raceklasseContainer.RaceklasseList.Contains(raceklasse));

            raceTeamContainer.RaceTeamList.Add(raceTeam);
            Assert.IsTrue(raceTeamContainer.RaceTeamList.Contains(raceTeam));

            raceTeamContainer.RaceTeamList.Remove(raceTeam);
            Assert.IsFalse(raceTeamContainer.RaceTeamList.Contains(raceTeam));
        }
    }
}
