using Microsoft.AspNet.OData;
using Microsoft.AspNetCore.Mvc;
using MongoDB.Driver;
using System.Linq;
using WebApiWithOData.Models;

namespace WebApiWithOData.Controllers
{
    [ApiVersion("1.0")] // can be removed
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
