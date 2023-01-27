using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace ModuloAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class UsuarioController : ControllerBase
    {
        [HttpGet("ObterDataHoraAtual")]
        public IActionResult ObterDataHora()
        {
            var obj = new
            {
                Data = MvcDataAnnotationsMvcBuilderExtensions.Now.ToLongDateString(),
                Hora = MvcDataAnnotationsMvcBuilderExtensions.Now.ToShortTimeString()
            };

            return Ok(obj);
        }

        [HttpGet("Apresentar/{name}")]
        public IActionResult Apresentar(string name)
        {
            var mensagem = $"Olá {name}, Seja bem vindo";
            return Ok(new Object{ mensagem });
        }
    }
}