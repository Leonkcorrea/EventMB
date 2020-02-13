using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using EventMB.Data;
using EventMB.Models;
namespace EventMB.Controllers
{
    [ApiController]
    [Route("v1/ingressos")]
    public class IngressoController : ControllerBase
    {
        [HttpGet]
        [Route("")]
        public async Task<ActionResult<List<Ingresso>>> Get([FromServices] DataContext context)
        {
            var ingressos = await context.Ingressos.ToListAsync();
            return ingressos;
        }
        [HttpGet]
        [Route("{id:int}")]
        public async Task<ActionResult<Ingresso>> GetById([FromServices] DataContext context, int id)
        {
            var ingressos = await context.Ingressos.Include(x => x.Eventos).FirstOrDefaultAsync(x=> x.Id_ingresso ==id );
            return ingressos;
        }
       [HttpDelete("{id:int}")]
        public async Task<ActionResult<Ingresso>> DeleteTodoItem([FromServices] DataContext context,long id)
        {
            var Ingresso = await context.Ingressos.FindAsync(id);
            if (Ingresso == null)
            {
                return NotFound();
            }

            context.Ingressos.Remove(Ingresso);
            await context.SaveChangesAsync();

            return Ingresso;
        }
        [HttpPost]
        [Route("")]
        public async Task<ActionResult<Ingresso>> Post(
            [FromServices] DataContext context,
            [FromBody] Ingresso model)
            {
                if(ModelState.IsValid)
                {
                    context.Ingressos.Add(model);
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