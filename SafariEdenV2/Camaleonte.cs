using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SafariEdenV2
{
    internal class Camaleonte : Animale
    {
        public Camaleonte(string name, DateTime dataUltimoPasto, int età, string dimensioni, string colore ) : base(name, dataUltimoPasto, età, dimensioni)
        {
            Colore = colore;
        }

        public Camaleonte() { }

        string Colore { get; set; }

        public override string GetToString()
        {
            return $"Nome: {Name}, Data ultimo pasto: {DataUltimoPasto}, Età: {Età}, Dimensione: {Dimensioni}, Colore: {Colore}";
        }
    }
}
