using System;
using System.Collections.Generic;
using System.Text;

namespace MusicalInstrument.Models
{
    public interface IStringInstrument
    {
        public string Play();
        public string FineTuneInstrument();
    }
}
