using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SafariEdenV2
{
    internal class Coccodrillo : Animale
    {
        public Coccodrillo(string name, DateTime dataUltimoPasto, int età, string dimensioni, string temperamento) : base(name, dataUltimoPasto, età, dimensioni)
        {
            Temperamento = temperamento;
        }

        public Coccodrillo() { }
        string Temperamento { get; set; }

        public override string GetToString()
        {
            return $"Nome: {Name}, Data ultimo pasto: {DataUltimoPasto}, Età: {Età}, Dimensione: {Dimensioni}, Colore: {Temperamento}";
        }

        public void Verso()
        {

        }
    }
}
