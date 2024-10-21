using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SafariEdenV2
{
    internal abstract class Animale
    {
        protected Animale(string name, DateTime dataUltimoPasto, int età, string dimensioni)
        {
            Name = name;
            DataUltimoPasto = dataUltimoPasto;
            Età = età;
            Dimensioni = dimensioni;
        }

        public Animale() { }

        public string Name { get; set; }
        public DateTime DataUltimoPasto { get; set; }
        public int Età { get; set; }
        public string Dimensioni { get; set; }


        virtual public string GetToString()
        {
            return $"Nome: {Name}, Data ultimo pasto: {DataUltimoPasto}, Età: {Età}, Dimensione: {Dimensioni}";
        }

        public string LastFeed()
        {
            return $"Nome: {Name} \tData ultimo pasto: {DataUltimoPasto}\n";
        }

        public string FeedAnimal()
        {
            this.DataUltimoPasto = DateTime.Now;
            return $"{Name} ha mangiato";
        }
    }
}
