using System;
using System.Collections.Generic;
using System.Text;

namespace Class__object
{
    class Car
    {
        public string znacka;
        public string model;
        public int pocetKoni;
        public int pocetKm;
        public string jeKProdeji;
        public string jePorouchano;
        public int cena;

        public void vypisvse()
        {
            Console.WriteLine("Znacka: " + znacka);
            Console.WriteLine("Model:  " + model);
            Console.WriteLine("Pocet Koni: " + pocetKoni + "hp");
            Console.WriteLine("Pocet KM: " + pocetKm + "km");
            Console.WriteLine("Je k prodeji?: " + jeKProdeji);
            Console.WriteLine("je Porouchano?: " + jePorouchano);
            Console.WriteLine("Cena: " + cena +"kc");
        }
    }
}
