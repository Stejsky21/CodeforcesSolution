using System;

namespace Class__object
{
    class ClassProgram
    {
        static void Main(string[] args)
        {
            Car auto1 = new Car();
            auto1.znacka = "Skoda";
            auto1.model = "Octavia";
            auto1.pocetKoni = 420;
            auto1.pocetKm = 99520;
            auto1.jeKProdeji = "ANO";
            auto1.jePorouchano = "NE";
            auto1.cena = 440000;

            Car auto2 = new Car();
            auto2.znacka = "Seat";
            auto2.model = "Toledo";
            auto2.pocetKoni = 120;
            auto2.pocetKm = 335000;
            auto2.jeKProdeji = "ANO";
            auto2.jePorouchano = "ANO";
            auto2.cena = 59000;

            //auto1.vypisvse();
            //Console.WriteLine(string.Empty);
            //auto2.vypisvse();

        }
    }
}
