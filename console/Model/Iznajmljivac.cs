using System;
using System.Collections.Generic;
using System.Text;
using MongoDB.Entities;

namespace console.Model
{
    class Iznajmljivac : Entity
    {
        public string ime { get; set; }

        public string prezime { get; set; }

        public int oib { get; set; }

        public Adresa adresa { get; set; }
    }

    public class Adresa
    {
        public string grad { get; set; }

        public string ulica { get; set; }

        public string broj { get; set; }

        public int postanski_broj { get; set; }
    }
}
