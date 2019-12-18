﻿using Swashbuckle.AspNetCore.Swagger;
using Swashbuckle.AspNetCore.SwaggerGen;
using System;
using System.Linq;
using Microsoft.OpenApi.Models;

namespace Digipolis.Web.Swagger
{
    // internal class SetVersionInPaths : IDocumentFilter
    // {
    //     public void Apply(OpenApiDocument swaggerDoc, DocumentFilterContext context)
    //     {
    //         swaggerDoc.Paths = swaggerDoc.Paths.ToDictionary(
    //             entry => entry.Key.Replace("{apiVersion}", swaggerDoc.Info.Version).Replace("{apiversion}", swaggerDoc.Info.Version),
    //             entry =>
    //             {
    //                 var pathItem = entry.Value;
    //                 RemoveVersionParamFrom(pathItem.Get);
    //                 RemoveVersionParamFrom(pathItem.Put);
    //                 RemoveVersionParamFrom(pathItem.Post);
    //                 RemoveVersionParamFrom(pathItem.Delete);
    //                 RemoveVersionParamFrom(pathItem.Options);
    //                 RemoveVersionParamFrom(pathItem.Head);
    //                 RemoveVersionParamFrom(pathItem.Patch);
    //                 return pathItem;
    //             });
    //     }
    //
    //     private void RemoveVersionParamFrom(Operation operation)
    //     {
    //         if (operation == null || operation.Parameters == null) return;
    //
    //         var versionParam = operation.Parameters.FirstOrDefault(param => param.Name.Equals("apiVersion", StringComparison.CurrentCultureIgnoreCase));
    //         if (versionParam == null) return;
    //
    //         operation.Parameters.Remove(versionParam);
    //     }
    // }


}
