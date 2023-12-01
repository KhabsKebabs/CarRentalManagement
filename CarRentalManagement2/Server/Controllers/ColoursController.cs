using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using CarRentalManagement2.Server.Data;
using CarRentalManagement2.Shared.Domain;

namespace CarRentalManagement2.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ColoursController : ControllerBase
    {
        private readonly ApplicationDbContext _context;

        public ColoursController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: api/Colours
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Colour>>> GetColours()
        {
            if (_context.Colours == null)
            {
                return NotFound();
            }
            return await _context.Colours.ToListAsync();
        }

        // GET: api/Colours/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Colour>> GetColour(int id)
        {
            if (_context.Colours == null)
            {
                return NotFound();
            }
            var Colour = await _context.Colours.FindAsync(id);

            if (Colour == null)
            {
                return NotFound();
            }

            return Colour;
        }

        // PUT: api/Colours/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutColour(int id, Colour Colour)
        {
            if (id != Colour.Id)
            {
                return BadRequest();
            }

            _context.Entry(Colour).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!ColourExists(id))
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

        // POST: api/Colours
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<Colour>> PostColour(Colour Colour)
        {
            if (_context.Colours == null)
            {
                return Problem("Entity set 'ApplicationDbContext.Colours'  is null.");
            }
            _context.Colours.Add(Colour);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetColour", new { id = Colour.Id }, Colour);
        }

        // DELETE: api/Colours/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteColour(int id)
        {
            if (_context.Colours == null)
            {
                return NotFound();
            }
            var Colour = await _context.Colours.FindAsync(id);
            if (Colour == null)
            {
                return NotFound();
            }

            _context.Colours.Remove(Colour);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool ColourExists(int id)
        {
            return (_context.Colours?.Any(e => e.Id == id)).GetValueOrDefault();
        }
    }
}
