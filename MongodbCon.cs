using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MongoDB.Bson;
using MongoDB.Driver;

namespace Hangxing
{
    class MongodbCon
    {
        public static void Insert()
        {
            var client = new MongoClient("mongodb://127.0.0.1:27017");
            var database = client.GetDatabase("foo");
            var collection = database.GetCollection<BsonDocument>("bar");
            var document = new BsonDocument
  {
  { "name", "测试数据1" },
  { "type", "大类" },
  { "number", 5 },
  { "info", new BsonDocument
    {
    { "x", 111 },
    { "y", 222 }
    }}
  };
            collection.InsertOne(document);
            Console.WriteLine("Hello World!");
        }
    }
}
