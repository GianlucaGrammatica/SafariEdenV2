using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SafariEdenV2
{
    internal class Pinguino : Animale
    {
        public Pinguino(string name, DateTime dataUltimoPasto, int età, string dimensioni, string nomeInCodice) : base(name, dataUltimoPasto, età, dimensioni)
        {
            NomeInCodice = nomeInCodice;
        }

        public Pinguino() { }

        string NomeInCodice { get; set; }

        public override string GetToString()
        {
            return $"Nome: {Name}, Data ultimo pasto: {DataUltimoPasto}, Età: {Età}, Dimensione: {Dimensioni}, Colore: {NomeInCodice}";
        }
    }
}
