using System;
using System.Collections.Generic;
using System.Text;
using MongoDB.Bson;
using MongoDB.Entities;
using Newtonsoft.Json;

namespace console.Common
{
    public static class Logger
    {
        public static void Log<T>( string message, IEnumerable<T> result )
        {
            var json = JsonConvert.SerializeObject( result, Formatting.Indented );

            Console.WriteLine( "\n*************************" );

            Console.WriteLine( $"{message} : { typeof( T ).Name}\n{json}" );
        }
    }
}
