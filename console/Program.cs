using System;
using System.Linq.Expressions;
using console.Common;
using console.Example;
using console.Model;
using MongoDB.Driver;

namespace console
{
    class Program
    {
        static void Main( string[] args )
        {
            var client = new MongoClient();

            var database = client.GetDatabase( "turizam" );

            var allDataExample = database.GetAll<Objekt>( "objekti" );

            Logger.Log( "Example of all data return", allDataExample );

            Expression<Func<Ugovor, bool>> expression = x =>
                x.datum_do >= DateTime.Now && 
                x.datum_od <= DateTime.Now && 
                x.affiliate;

            var activeAffContracts = database.GetAll( "ugovori", expression );

            Logger.Log( "Example of filtered data \nOnly those who are active and affiliate", activeAffContracts );

            //lookup
            //{
            //    from:'iznajmljivaci',
            //  localField:'iznajmljivac_id',
            //  foreignField:'_id',
            //  as: 'test'
            //}
            

            var contractWithLandlord = database.GetAll<Ugovor>( "ugovori", "iznajmljivaci", "iznajmljivac_id", "_id", "iznajmljivac" );

            Logger.Log( "Example of referenced data with projection", contractWithLandlord );

            var toInsert = new Cjenik();

            database.Insert( toInsert );

            Console.ReadLine();
        }
    }
}
