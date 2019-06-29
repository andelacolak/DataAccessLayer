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
        public ObjectId smjestajnajedinica_id { get; set; }

        public DateTime datum_od { get; set; }

        public DateTime datum_do { get; set; }

        public Cijena cijena { get; set; }

        public IEnumerable<SmjestajnaJedinica> smjestajnaJedinica { get; set; }

        public Cjenik()
        {
            smjestajnajedinica_id = new ObjectId( "5d07f570ffd5072bd4faee62" );

            datum_od = DateTime.Now;

            datum_do = DateTime.Now.AddYears( 1 );

            cijena = new Cijena();
        }
    }

    class Cijena
    {
        public double iznos { get; set; }

        public Valuta valuta { get; set; }

        public Cijena()
        {
            iznos = 100.00;

            valuta = new Valuta();
        }
    }

    class Valuta
    {
        public string iso3 { get; set; }

        public string simbol { get; set; }

        public Valuta()
        {
            iso3 = "USD";

            simbol = "$";
        }
    }
}
