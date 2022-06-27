using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using EventsAPI.Data;
using EventsAPI.Models;

namespace EventsAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class IngressosController : ControllerBase
    {
        private readonly Context _context;

        public IngressosController(Context context)
        {
            _context = context;
        }

        // GET: api/Ingressos
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Ingresso>>> GetIngressos()
        {
            return await _context.Ingressos.ToListAsync();
        }

        // GET: api/Ingressos/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Ingresso>> GetIngresso(int id)
        {
            var ingresso = await _context.Ingressos.FindAsync(id);

            if (ingresso == null)
            {
                return NotFound();
            }

            return ingresso;
        }

        // PUT: api/Ingressos/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutIngresso(int id, Ingresso ingresso)
        {
            if (id != ingresso.Id)
            {
                return BadRequest();
            }

            _context.Entry(ingresso).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!IngressoExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return NoContent();
        }

        // POST: api/Ingressos
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<Ingresso>> PostIngresso(Ingresso ingresso)
        {
            _context.Ingressos.Add(ingresso);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetIngresso", new { id = ingresso.Id }, ingresso);
        }

        // DELETE: api/Ingressos/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteIngresso(int id)
        {
            var ingresso = await _context.Ingressos.FindAsync(id);
            if (ingresso == null)
            {
                return NotFound();
            }

            _context.Ingressos.Remove(ingresso);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool IngressoExists(int id)
        {
            return _context.Ingressos.Any(e => e.Id == id);
        }
    }
}
