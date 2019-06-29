using System;
using System.Collections.Generic;
using System.Text;
using MongoDB.Bson;
using MongoDB.Entities;

namespace console.Model
{
    class SmjestajnaJedinica : Entity
    {
        public string tip { get; set; }

        public int zvjezdice { get; set; }

        public ObjectId objekt_id { get; set; }

        public bool objava { get; set; }

        public Atribut atributi { get; set; }

        public Objekt objekt { get; set; }
    }

    class Atribut
    {
        public bool klima { get; set; }

        public bool ljubimci { get; set; }

        public bool dorucak { get; set; }
    }
}
