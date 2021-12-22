using Common.Entities;
using Common.Interfaces;
using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Infrastructure
{
    public class DataAccessRoom : IDataAccessRoom
    {
        
        private IMongoDatabase _db;
        private IMongoClient _mongoClient;

        public DataAccessRoom()
        {  
            string connectionString = "mongodb://localhost:27017";
            _mongoClient = new MongoClient(connectionString);
        }

        public void CreateDataBase(string database)
        {
            _db = _mongoClient.GetDatabase(database);
        }

        public void InsertRoom<T>(string table, T room)
        {
            var collection = _db.GetCollection<T>(table);
            collection.InsertOne(room);
        }

    }
}
