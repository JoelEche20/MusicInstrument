using MusicalInstrument.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace MusicalInstrument
{
    class Program
    {
        static void Main(string[] args)
        {
            List<StringInstrument> stringInstruments = new List<StringInstrument>();
            Guitar guitar = new Guitar("Guitarra Acustica","Dreadnought",6);
            Piano piano = new Piano("Piano", "Piano de Cola", 230);
            stringInstruments.Add(guitar);
            stringInstruments.Add(piano);
            Console.WriteLine(guitar.Play());
            Console.WriteLine(guitar.Play());
            Console.WriteLine(piano.Play());
            Console.WriteLine(guitar.showTuning());
            Console.WriteLine(piano.showTuning());

            foreach (StringInstrument instrument in stringInstruments)
            {
                guitar.FineTune();
                piano.FineTune();
            }

            Console.WriteLine(guitar.showTuning());
            Console.WriteLine(piano.showTuning());

        }
    }
}
