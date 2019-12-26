using Microsoft.AspNet.OData;
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
            return new string[]
                { "Alice", "Bob", "Chloe", "Dorothy", "Emma", "Fabian", "Garry", "Hannah", "Julian" }
                .Select(v => new Book { Title = v, Author ="yww", Year = new Random().Next(2000,2020) })
                .AsQueryable();
        }
    }
}
