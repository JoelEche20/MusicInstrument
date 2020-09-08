using System;
using System.Collections.Generic;
using System.Text;

namespace MusicalInstrument.Models
{
    public class Piano : StringInstrument, IStringInstrument
    {
        public int NumberBlackKeys  { get; set; }
        public int NumberWhiteKeys { get; set; }
        public int NumberPedal { get; set; }

        public Piano()
        {

        }
        public Piano(string originalName, string name, int numberStrings)
        {
            this.OriginalName = originalName;
            this.Name = name;
            this.NumberStrings = numberStrings;
        }

        public string FineTuneInstrument()
        {
            FineTune();
            return "Piano fine tune";
        }

        public string Play()
        {
            DeTune();
            return "Use the keyboard";
        }
    }
}
