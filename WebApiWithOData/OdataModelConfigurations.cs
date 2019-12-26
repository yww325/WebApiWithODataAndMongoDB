using Microsoft.AspNet.OData.Builder;
using Microsoft.AspNetCore.Mvc;
using WebApiWithOData.Models;

namespace WebApiWithOData
{
    public class OdataModelConfigurations : IModelConfiguration
    {
        public void Apply(ODataModelBuilder builder, ApiVersion apiVersion)
        {
            builder.EntitySet<Book>("Books");
            
            builder.EntityType<Book>().HasKey(ai => ai.Title); // the call to HasKey is mandatory
        }
    }
}
