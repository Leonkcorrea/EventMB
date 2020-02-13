using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using EventMB.Data;
using EventMB.Models;
namespace EventMB.Controllers
{
    [ApiController]
    [Route("v1/eventos")]
    public class EventoController : ControllerBase
    {
        [HttpGet]
        [Route("")]
        public async Task<ActionResult<List<Evento>>> Get([FromServices] DataContext context)
        {
            var eventos = await context.Eventos.ToListAsync();
            return eventos;
        }
       
        [HttpPost]
        [Route("")]
        public async Task<ActionResult<Evento>> Post(
            [FromServices] DataContext context,
            [FromBody] Evento model)
            {
                if(ModelState.IsValid)
                {
                    context.Eventos.Add(model);
                    await context.SaveChangesAsync();
                    return model;
                }
                else
                {
                    return BadRequest(ModelState);
                }
            }



    }
}