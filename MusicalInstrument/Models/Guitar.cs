using System;
using System.Collections.Generic;
using System.Text;

namespace MusicalInstrument.Models
{
    public class Guitar : StringInstrument, IStringInstrument
    {
        public int NumberMast { get; set; }
        public int NumberFrets { get; set; }

        public Guitar()
        {

        }
        public Guitar(string originalName, string name, int numberStrings)
        {
            this.OriginalName = originalName;
            this.Name = name;
            this.NumberStrings = numberStrings;
        }

        public string FineTuneInstrument()
        {
            FineTune();
            return "Guitar fine tune";
        }

        public string Play()
        {
            DeTune();
            return "Used the strings";
        }
    }
}
