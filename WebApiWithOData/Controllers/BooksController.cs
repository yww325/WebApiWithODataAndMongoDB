using Microsoft.AspNet.OData;
using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApiWithOData.Models;

namespace WebApiWithOData.Controllers
{ 
    public class BooksController : ODataController
    {
        [EnableQuery]
        public IQueryable<Book> Get()
        {
            var connectionString = "mongodb://localhost:27017";
            var client = new MongoClient(connectionString);
            IMongoDatabase db = client.GetDatabase("testdb");
            IMongoCollection<Book> collection = db.GetCollection<Book>("books"); 
            return collection.AsQueryable();
        }
    }
}
