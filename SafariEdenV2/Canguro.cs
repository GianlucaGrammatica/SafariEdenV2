using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SafariEdenV2
{
    internal class Canguro : Animale
    {
        public Canguro(string name, DateTime dataUltimoPasto, int età, string dimensioni, string madre ) : base(name, dataUltimoPasto, età, dimensioni)
        {
            Madre = madre;
        }

        public Canguro() { }

        string Madre { get; set; }

        public override string GetToString()
        {
            return $"Nome: {Name}, Data ultimo pasto: {DataUltimoPasto}, Età: {Età}, Dimensione: {Dimensioni}, Madre: {Madre}";
        }
    }
}
