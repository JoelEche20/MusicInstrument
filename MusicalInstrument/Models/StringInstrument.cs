using System;
using System.Collections.Generic;
using System.Text;

namespace MusicalInstrument.Models
{
    public abstract class StringInstrument
    {
        protected string OriginalName { get; set; }
        protected string Name { get; set; }
        protected int NumberStrings { get; set; }
        private int _tuning { get; set; }

        public StringInstrument() 
        {
            _tuning = 100;
        }
        public void FineTune()
        {
            _tuning = 100;
        }

        public void DeTune()
        {
            _tuning = _tuning - 5;
        }

        public int showTuning()
        {
            return _tuning;
        }

    }
}
