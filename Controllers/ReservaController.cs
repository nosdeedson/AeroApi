using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AeroApi.Model;
using AeroApi.Request;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace AeroApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ReservaController : ControllerBase
    {
        private List<Reserva> Reservas = new List<Reserva>();
        private int Id = 1;
        [HttpPost]
        public IActionResult EfetuarReserva(EfetuarReservaRequest request)
        {
            var reserva = new Reserva();
            reserva.Id = Id;
            Id++;
            reserva.Documento = request.Documento;
            reserva.Poltrona = request.Poltrona;
            reserva.VooId = request.VooId;

            Reservas.Add(reserva);

            return Ok(reserva);
        }


        [HttpGet("{id}")]
        public IActionResult BuscarPorId(int id)
        {
            return null;
        }

        [HttpGet("buscarPorVoo{VooID}")]
        public IActionResult BuscarPorVoo(int id)
        {
            return null;
        }

        [HttpGet("buscarPorPoltrona{poltrona}")]
        public IActionResult BuscarPorPoltrona(int poltrona)
        {
            return null;
        }

        [HttpPut]
        public IActionResult Editar(EditarReservaRequest request)
        {
            return null;
        }

        [HttpDelete("{id}")]
        public IActionResult Excluir(int id)
        {
            return null;
        }

    }


}
