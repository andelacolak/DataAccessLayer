using System;
using System.Collections.Generic;
using System.Text;
using MongoDB.Bson;
using MongoDB.Entities;

namespace console.Model
{
    class Objekt : Entity
    {
        public ObjectId iznajmljivac_id { get; set; }

        public Lokacija lokacija { get; set; }

        public Iznajmljivac iznajmljivac { get; set; }
    }

    class Lokacija
    {
        public string grad { get; set; }

        public decimal longitude { get; set; }

        public decimal latitude { get; set; }
    }
}
