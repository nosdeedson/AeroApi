using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using AeroApi.Model;
using AeroApi.DTO;

namespace AeroApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class VoosController : ControllerBase
    {
        private readonly AeroContext _context;

        public VoosController(AeroContext context)
        {
            _context = context;
        }

        // GET: api/Voos
        [HttpGet]
        public IActionResult GetVoos()
        {
            return Ok(Converter(_context.Voos.ToList()));
        }


        // GET: api/Voos
        [HttpGet("comFiltro")]
        public ActionResult<IEnumerable<dynamic>> GetVoosFiltro([ FromQuery] FiltroVooDTO filtro)
        {
            var listaRetorno = _context.Voos.Where(item => item.DataIda >= filtro.DataIda &&
            item.DataVolta <= filtro.DataVolta && item.QtdPassageiros >  filtro.QtdPassageiroDTO &&
            item.LocalDestinoId == filtro.LocalDestinoID && item.LocalOrigemId == filtro.LocalOrigemID ).ToList();

            return Ok(Converter(listaRetorno));
        }

       private IEnumerable<dynamic> Converter(List<Voo> lista)
        {
           return lista.Select( item => new {
                item.Id,
                item.DataIda,
                item.DataVolta,
                item.TempoIda,
                item.TempoVolta,
                item.LocalOrigemId,
                item.LocalDestinoId,
                item.NumeroParadas,
                item.Preco
            } ).ToList();
        }


    }
}
