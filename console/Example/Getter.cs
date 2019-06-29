using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using console.Common;
using console.Model;
using MongoDB.Bson;
using MongoDB.Bson.Serialization;
using MongoDB.Driver;
using MongoDB.Entities;

namespace console.Example
{
    public static class Getter
    {
        public static IEnumerable<T> GetAll<T>( this IMongoDatabase db, string collection, string projection = null ) 
                where T : Entity
        {
            Expression<Func<T, bool>> expression = x => x.ID != null;

            return GetAll( db, collection, expression, projection );
        }

        public static IEnumerable<T> GetAll<T>( this IMongoDatabase db, string collection, Expression<Func<T,bool>> expression, string projection = null ) 
                where T : Entity
        {
            return db.GetCollection<T>( collection )
                .Find( expression )
                .Project( projection ?? "{}" )
                .ToList()
                .Select( x => BsonSerializer.Deserialize<T>( x ) );
        }

        public static IEnumerable<T> GetAll<T>( this IMongoDatabase db, string collection, string from, string localField, string foreignField, string asField, ProjectionDefinition<T,T> projection = null )
            where T : Entity
        {
            Expression<Func<T, bool>> expression = x => x.ID != null;

            return db.GetCollection<T>( collection )
                .Aggregate()
                .Project( projection ?? "{ datum_od:1 }" )
                .Lookup( from, localField, foreignField, asField )
                .ToList()
                .Select( x => BsonSerializer.Deserialize<T>( x ) );
        }

        public static bool Insert<T>( this IMongoDatabase db, T toInsert )
        {
            return db.Insert( toInsert );
        }
    }
}
