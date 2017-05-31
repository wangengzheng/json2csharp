using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Json2CSharp.Web.Dtos;
using Xamasoft.JsonClassGenerator;
using System.IO;
using Xamasoft.JsonClassGenerator.CodeWriters;

namespace Json2CSharp.Web.Controllers
{
    [Route("api/json2csharp")] 
    public class Json2CSharpController : Controller
    {
        [HttpPost]
        public async Task<IActionResult> Get(Json2CSharpPostRequestDto vm)
        {
            try
            {
                var gen = new JsonClassGenerator();
                gen.Example = vm.Example;
                gen.MainClass = "RootObject";
                gen.GenerateClasses();
                gen.UsePascalCase = vm.UsePascalCase;
                gen.UseProperties = vm.UseProperties;

                var csharpCodeWriter = new CSharpCodeWriter();
                var resultWriter = new StringWriter();
                csharpCodeWriter.WriteFileStart(gen, resultWriter);
                foreach (var type in gen.Types)
                {
                    csharpCodeWriter.WriteClass(gen, resultWriter, type);
                }
                csharpCodeWriter.WriteFileEnd(gen, resultWriter);

                return Ok(new Json2CSharpPostResponseDto()
                {
                    Result = resultWriter.ToString()
                });
            }
            catch (Exception e )
            {
                return BadRequest();
            }
        }

    }
}
