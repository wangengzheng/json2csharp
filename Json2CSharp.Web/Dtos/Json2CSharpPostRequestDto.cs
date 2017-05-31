using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Json2CSharp.Web.Dtos
{
    public class Json2CSharpPostRequestDto
    {
        public string Example { get; set; }
        public bool UsePascalCase { get;  set; }
        public bool UseProperties { get;  set; }
    }
}
