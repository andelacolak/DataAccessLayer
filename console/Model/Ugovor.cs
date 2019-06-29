using System;
using System.Collections.Generic;
using System.Text;
using MongoDB.Bson;
using MongoDB.Entities;

namespace console.Model
{
    class Ugovor : Entity
    {
        public DateTime datum_od { get; set; }

        public DateTime datum_do { get; set; }

        public decimal provizija { get; set; }

        public bool affiliate { get; set; }

        public bool b2b { get; set; }

        public ObjectId iznajmljivac_id { get; set; }
        
        public IEnumerable<Iznajmljivac> iznajmljivac { get; set; }
    }
}
