using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using EventMB.Data;
using EventMB.Models;
namespace EventMB.Controllers
{
    [ApiController]
    [Route("v1/clientes")]
    public class PEController : ControllerBase
    {   //Lista todos os clientes
        [HttpGet]
        [Route("")]
        public async Task<ActionResult<List<PromoEvent>>> Get([FromServices] DataContext context)
        {
            var pevents = await context.promotores.ToListAsync();
            return pevents;
        }
        //DELETE cliente por id
        [HttpDelete("{id:int}")]
        public async Task<ActionResult<PromoEvent>> Delete([FromServices] DataContext context,int id)
        {
            var promotores = await context.promotores.FindAsync(id);
            if (promotores == null)
            {
                return NotFound();
            }

            context.promotores.Remove(promotores);
            await context.SaveChangesAsync();

            return promotores;
        }
        [HttpPost]
        [Route("")]
        public async Task<ActionResult<Cliente>> Post(
            [FromServices] DataContext context,
            [FromBody] Cliente model)
            {
                if(ModelState.IsValid)
                {
                    context.Clientes.Add(model);
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