using Microsoft.VisualStudio.TestTools.UnitTesting;
using F1OpdrachtLibrary;

namespace F1OpdrachtTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            Raceklasse raceklasse = new Raceklasse();
            raceklasse.Naam = "F1";
            Assert.AreEqual("F1", raceklasse.Naam);

            Seizoen seizoen = new Seizoen();
            seizoen.Aantalraces = 4;
            Assert.AreEqual(4, seizoen.Aantalraces);

            RaceTeam raceTeam = new RaceTeam();
            raceTeam.Actief = true;
            Assert.AreEqual(true, raceTeam.Actief);
        }
    }
}
