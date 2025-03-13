using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using JWTAuthJWTBearerWebApi.Models;

namespace JWTAuthJWTBearerWebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ITRolesController : ControllerBase
    {
        private readonly AppDBContext _context;

        public ITRolesController(AppDBContext context)
        {
            _context = context;
        }

        // GET: api/ITRoles
        [HttpGet]
        public async Task<ActionResult<IEnumerable<ITRole>>> GetITRoles()
        {
          if (_context.ITRoles == null)
          {
              return NotFound();
          }
            return await _context.ITRoles.ToListAsync();
        }

        // GET: api/ITRoles/5
        [HttpGet("{id}")]
        public async Task<ActionResult<ITRole>> GetITRole(int id)
        {
          if (_context.ITRoles == null)
          {
              return NotFound();
          }
            var iTRole = await _context.ITRoles.FindAsync(id);

            if (iTRole == null)
            {
                return NotFound();
            }

            return iTRole;
        }

        // PUT: api/ITRoles/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutITRole(int id, ITRole iTRole)
        {
            if (id != iTRole.ITRoleId)
            {
                return BadRequest();
            }

            _context.Entry(iTRole).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!ITRoleExists(id))
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

        // POST: api/ITRoles
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<ITRole>> PostITRole(ITRole iTRole)
        {
          if (_context.ITRoles == null)
          {
              return Problem("Entity set 'AppDBContext.ITRoles'  is null.");
          }
            _context.ITRoles.Add(iTRole);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetITRole", new { id = iTRole.ITRoleId }, iTRole);
        }

        // DELETE: api/ITRoles/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteITRole(int id)
        {
            if (_context.ITRoles == null)
            {
                return NotFound();
            }
            var iTRole = await _context.ITRoles.FindAsync(id);
            if (iTRole == null)
            {
                return NotFound();
            }

            _context.ITRoles.Remove(iTRole);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool ITRoleExists(int id)
        {
            return (_context.ITRoles?.Any(e => e.ITRoleId == id)).GetValueOrDefault();
        }
    }
}
