using System;
using System.Collections.Generic;

namespace oraimunka1005
{
    internal class Haromszog
    {
        private int aoldal;
        private int boldal;
        private int coldal;

        public double Terulet { get; private set; }
        public double Kerulet { get; private set; }
        public bool Szerkesztheto { get; private set; }

        public List<string> AdatokSzoveg()
        {
            List<string> adatok = new List<string>();
            adatok.Add($"A: {aoldal} - B: {boldal} - C: {coldal}");
             adatok.Add($"Kerület: {Kerulet} - Terület: {Terulet}");
            if (Szerkesztheto)
            {
                adatok.Add($"Kerület: {Kerulet} - Terület: {Terulet}");
            }
            else
            {
                adatok.Add("Nem szerkeszthető");
            }
            return adatok;
        }
        private double Teruletszamitas()
        {
            double s = (aoldal + boldal + coldal) / 2;
            double ter = Math.Sqrt(s * (s - aoldal) * (s - boldal) * (s - coldal));
            return ter;
        }
        private double Keruletszamitas()
        {
            double ker = aoldal + boldal + coldal;
            return ker;
        }

        private void szerk()
        {
            if (aoldal + boldal > coldal && aoldal + coldal > boldal && boldal + coldal > aoldal)
            {
                Szerkesztheto = true;
                Terulet = Teruletszamitas();
                Kerulet = Keruletszamitas();
                
            }
            else
            {
                Szerkesztheto = false;
                Terulet = 0;
                Kerulet = 0;
            }
        }
        public Haromszog(int aoldal, int boldal, int coldal)
        {
            this.aoldal = aoldal;
            this.boldal = boldal;
            this.coldal = coldal;
            szerk();
        }
    }
}