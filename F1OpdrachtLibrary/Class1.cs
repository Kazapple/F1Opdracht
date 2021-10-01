using System;

namespace F1OpdrachtLibrary
{
    public class Raceklasse
    {
        public string Naam { get; set; }
        public string Standplaats { get; set; }
        public string Hoofdsponsor { get; set; }
        public int Oprichtingsjaar { get; set; }
        public string Directeur { get; set; }
    }

    public class Seizoen
    {
        public int Aantalraces { get; set; }
        public string Kampioen { get; set; }
        public string Periode { get; set; }
    }

    public class RaceTeam
    {
        public string Naam { get; set; }
        public string Aantalraces { get; set; }
        public bool Actief { get; set; }
    }
}
