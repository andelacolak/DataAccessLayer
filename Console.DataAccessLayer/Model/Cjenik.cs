using System;
using System.Collections.Generic;
using System.Text;
using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using MongoDB.Bson.Serialization.IdGenerators;
using MongoDB.Entities;

namespace console.Model
{
    class Cjenik : Entity
    {
        public string smjestajnajedinica { get; set; }

        public DateTime datum_od { get; set; }

        public DateTime datum_do { get; set; }

        public Cijena cijena { get; set; }
    }

    class Cijena
    {
        public double iznos { get; set; }

        public Valuta valuta { get; set; }
    }

    class Valuta
    {
        public string iso3 { get; set; }

        public string simbol { get; set; }
    }
}
