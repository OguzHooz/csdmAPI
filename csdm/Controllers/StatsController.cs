using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using csdm.Data;
using csdm.Models;

namespace csdm.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StatsController : ControllerBase
    {
        private readonly csdmContext _context;

        public StatsController(csdmContext context)
        {
            _context = context;
        }

        // GET: api/Roots
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Root>>> GetRoot()
        {
            return await _context.Root
                .Include(r => r.teamA)
                .Include(r => r.teamB)
                .Include(r => r.players)
                .Include(r => r.rounds)
                .ToListAsync();
        }

        // GET: api/Roots/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Root>> GetRoot(string id)
        {
            var root = await _context.Root
                .Include(r => r.teamA)
                .Include(r => r.teamB)
                .Include(r => r.players)
                .Include(r => r.rounds)
                .SingleOrDefaultAsync(r => r.checksum == id);

            if (root == null)
            {
                return NotFound();
            }

            return root;
        }

        // PUT: api/Roots/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutRoot(string id, Root root)
        {
            if (id != root.checksum)
            {
                return BadRequest();
            }

            _context.Entry(root).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!RootExists(id))
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

        // POST: api/Roots
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<Root>> PostRoot(Root root)
        {
            _context.Root.Add(root);
            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateException)
            {
                if (RootExists(root.checksum))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtAction("GetRoot", new { id = root.checksum }, root);
        }

        // DELETE: api/Roots/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteRoot(string id)
        {
            var root = await _context.Root.FindAsync(id);
            if (root == null)
            {
                return NotFound();
            }

            _context.Root.Remove(root);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool RootExists(string id)
        {
            return _context.Root.Any(e => e.checksum == id);
        }
    }
}
