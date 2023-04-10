using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using WEB_Service_Rest.Data;
using WEB_Service_Rest.Models;

namespace WEB_Service_Rest.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SaldosController : ControllerBase
    {
        private readonly APIDbContext _context;

        public SaldosController(APIDbContext context)
        {
            _context = context;
        }

        // GET: api/Saldos
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Saldo>>> GetSaldo()
        {
          if (_context.Saldo == null)
          {
              return NotFound();
          }
            return await _context.Saldo.ToListAsync();
        }

        // GET: api/Saldos/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Saldo>> GetSaldo(int id)
        {
          if (_context.Saldo == null)
          {
              return NotFound();
          }
            var saldo = await _context.Saldo.FindAsync(id);

            if (saldo == null)
            {
                return NotFound();
            }

            return saldo;
        }

        // PUT: api/Saldos/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutSaldo(int id, Saldo saldo)
        {
            if (id != saldo.IdSaldo)
            {
                return BadRequest();
            }

            _context.Entry(saldo).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!SaldoExists(id))
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

        // POST: api/Saldos
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<Saldo>> PostSaldo(Saldo saldo)
        {
          if (_context.Saldo == null)
          {
              return Problem("Entity set 'APIDbContext.Saldo'  is null.");
          }
            _context.Saldo.Add(saldo);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetSaldo", new { id = saldo.IdSaldo }, saldo);
        }

        // DELETE: api/Saldos/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteSaldo(int id)
        {
            if (_context.Saldo == null)
            {
                return NotFound();
            }
            var saldo = await _context.Saldo.FindAsync(id);
            if (saldo == null)
            {
                return NotFound();
            }

            _context.Saldo.Remove(saldo);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool SaldoExists(int id)
        {
            return (_context.Saldo?.Any(e => e.IdSaldo == id)).GetValueOrDefault();
        }
    }
}
