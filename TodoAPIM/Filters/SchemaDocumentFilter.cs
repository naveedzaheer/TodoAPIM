using Microsoft.OpenApi.Models;
using Swashbuckle.AspNetCore.Swagger;
using Swashbuckle.AspNetCore.SwaggerGen;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using IDocumentFilter = Swashbuckle.AspNetCore.SwaggerGen.IDocumentFilter;

namespace TodoAPIM.Filters
{
    public class SchemaDocumentFilter : IDocumentFilter
    {
        /// <summary>
        /// Applies filter context to swagger document.
        /// </summary>
        /// <param name="swaggerDoc"><see cref="SwaggerDocument"/> instance.</param>
        /// <param name="context"><see cref="DocumentFilterContext"/> instance.</param>
        //public void Apply(SwaggerDocument swaggerDoc, DocumentFilterContext context)
        //{
        //    swaggerDoc.host = "nzmovierest.azurewebsites.net";
        //    swaggerDoc.basePath = "/";
        //    swaggerDoc.schemes = new List<string>() { "https" };
        //}

        public void Apply(OpenApiDocument swaggerDoc, DocumentFilterContext context)
        {
            //swaggerDoc.Servers = new List<OpenApiServer>() { new OpenApiServer() { Url = "https://localhost:44374/" } };
            swaggerDoc.Servers = new List<OpenApiServer>() { new OpenApiServer() { Url = "https://nztodorest.azurewebsites.net/" } };
        }
    }
}