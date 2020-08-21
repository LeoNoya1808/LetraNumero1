using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using NumeroLetra1.Helpers;

namespace NumeroLetra1.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LiteralController : ControllerBase
    {
        [HttpGet]
        public string LiteralGet(int Numero)
        {
            return Conversores.NumeroALetras(Numero);

        }
        [HttpPost]
        public string LiteralPost([FromHeader] int Numero)
        {
            return Conversores.NumeroALetras(Numero);

        }
    }
}
