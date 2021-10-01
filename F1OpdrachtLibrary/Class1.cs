using System;
using System.Collections.Generic;

namespace F1OpdrachtLibrary
{
    public class Raceklasse
    {
        public string Naam { get; set; }
        public string Standplaats { get; set; }
        public string Hoofdsponsor { get; set; }
        public int Oprichtingsjaar { get; set; }
        public string Directeur { get; set; }

        List<Seizoen> seizoenList = new List<Seizoen>();
        public List<Seizoen> SeizoenList { get { return seizoenList; } }
    }

    public class Seizoen
    {
        public int Aantalraces { get; set; }
        public string Kampioen { get; set; }
        public string Periode { get; set; }

        List<RaceTeam> raceTeamList = new List<RaceTeam>();
        public List<RaceTeam> RaceTeamList { get { return raceTeamList; } }
    }

    public class RaceTeam
    {
        public string Naam { get; set; }
        public string Aantalraces { get; set; }
        public bool Actief { get; set; }

        List<Raceklasse> raceklasseList = new List<Raceklasse>();
        public List<Raceklasse> RaceklasseList { get { return raceklasseList; } }
    }
}
