﻿using System;
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
    public class ContasController : ControllerBase
    {
        private readonly APIDbContext _context;

        public ContasController(APIDbContext context)
        {
            _context = context;
        }

        // GET: api/Contas
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Conta>>> GetConta()
        {
          if (_context.Conta == null)
          {
              return NotFound();
          }
            return await _context.Conta.ToListAsync();
        }

        // GET: api/Contas/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Conta>> GetConta(int id)
        {
          if (_context.Conta == null)
          {
              return NotFound();
          }
            var conta = await _context.Conta.FindAsync(id);

            if (conta == null)
            {
                return NotFound();
            }

            return conta;
        }

        // PUT: api/Contas/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutConta(int id, Conta conta)
        {
            if (id != conta.IdConta)
            {
                return BadRequest();
            }

            _context.Entry(conta).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!ContaExists(id))
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

        // POST: api/Contas
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<Conta>> PostConta(Conta conta)
        {
          if (_context.Conta == null)
          {
              return Problem("Entity set 'APIDbContext.Conta'  is null.");
          }
            _context.Conta.Add(conta);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetConta", new { id = conta.IdConta }, conta);
        }

        // DELETE: api/Contas/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteConta(int id)
        {
            if (_context.Conta == null)
            {
                return NotFound();
            }
            var conta = await _context.Conta.FindAsync(id);
            if (conta == null)
            {
                return NotFound();
            }

            _context.Conta.Remove(conta);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool ContaExists(int id)
        {
            return (_context.Conta?.Any(e => e.IdConta == id)).GetValueOrDefault();
        }
    }
}
