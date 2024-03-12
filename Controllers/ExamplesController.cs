using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using project4.Models;

namespace project4.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ExamplesController : ControllerBase
    {
        private readonly project4Context _context;

        public ExamplesController(project4Context context)
        {
            _context = context;
        }

        // GET: api/Examples
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Example>>> GetExample()
        {
          if (_context.Example == null)
          {
              return NotFound();
          }
            return await _context.Example.ToListAsync();
        }

        // GET: api/Examples/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Example>> GetExample(int id)
        {
          if (_context.Example == null)
          {
              return NotFound();
          }
            var example = await _context.Example.FindAsync(id);

            if (example == null)
            {
                return NotFound();
            }

            return example;
        }

        // PUT: api/Examples/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutExample(int id, Example example)
        {
            if (id != example.ID)
            {
                return BadRequest();
            }

            _context.Entry(example).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!ExampleExists(id))
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

        // POST: api/Examples
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<Example>> PostExample(Example example)
        {
          if (_context.Example == null)
          {
              return Problem("Entity set 'project4Context.Example'  is null.");
          }
            _context.Example.Add(example);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetExample", new { id = example.ID }, example);
        }

        // DELETE: api/Examples/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteExample(int id)
        {
            if (_context.Example == null)
            {
                return NotFound();
            }
            var example = await _context.Example.FindAsync(id);
            if (example == null)
            {
                return NotFound();
            }

            _context.Example.Remove(example);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool ExampleExists(int id)
        {
            return (_context.Example?.Any(e => e.ID == id)).GetValueOrDefault();
        }
    }
}
