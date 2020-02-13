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
    public class ClienteController : ControllerBase
    {   //Lista todos os clientes
        [HttpGet]
        [Route("")]
        public async Task<ActionResult<List<Cliente>>> Get([FromServices] DataContext context)
        {
            var clientes = await context.Clientes.ToListAsync();
            return clientes;
        }
        //DELETE cliente por id
        [HttpDelete("{id:int}")]
        public async Task<ActionResult<Cliente>> Delete([FromServices] DataContext context,int id)
        {
            var clientes = await context.Clientes.FindAsync(id);
            if (clientes == null)
            {
                return NotFound();
            }

            context.Clientes.Remove(clientes);
            await context.SaveChangesAsync();

            return clientes;
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