using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SafariEdenV2
{
    internal class Orso : Animale
    {
        public Orso(string name, DateTime dataUltimoPasto, int età, string dimensioni, string ciboPreferito) : base(name, dataUltimoPasto, età, dimensioni)
        {
            CiboPreferito = ciboPreferito;
        }

        public Orso() { }
        string CiboPreferito { get; set; }

        public override string GetToString()
        {
            return $"Nome: {Name}, Data ultimo pasto: {DataUltimoPasto}, Età: {Età}, Dimensione: {Dimensioni}, Colore: {CiboPreferito}";
        }
    }
}
