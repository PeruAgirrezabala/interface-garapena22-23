﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using REST_API.Services;
using REST_API.Models;

namespace REST_API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SaskiaAleaController : ControllerBase
    {
        private readonly ISaskiaAleaService _saskiaAleaService;

        public SaskiaAleaController(ISaskiaAleaService saskiaAleaService)
        {
            _saskiaAleaService = saskiaAleaService;
        }

        // GET: api/SaskiaAlea
        [HttpGet]
        public async Task<ActionResult<List<SaskiaAlea>>> GetSaskiaAleak()
        {
            return await _saskiaAleaService.GetSaskiaAleak();
        }
        
        // GET: api/SaskiaAlea/5
        [HttpGet("{id}")]
        public async Task<ActionResult<SaskiaAlea>> GetSaskiaAlea(int id)
        {
            return await _saskiaAleaService.GetSaskiaAlea(id);
        }
        // PUT: api/SaskiaAlea/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutSaskiaAlea(int id, SaskiaAlea saskiaAlea)
        {
            if (id != saskiaAlea.Id)
            {
                return BadRequest();
            }

            try
            {
                await _saskiaAleaService.PutSaskiaAlea(saskiaAlea);
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!SaskiaAleaExists(id))
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

        // POST: api/SaskiaAlea
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<SaskiaAlea>> PostSaskiaAlea(SaskiaAlea saskiaAlea)
        {
            await _saskiaAleaService.PostSaskiaAlea(saskiaAlea);
            return CreatedAtAction("GetSaskiaAlea", new { id = saskiaAlea.Id }, saskiaAlea);
        }

        // DELETE: api/SaskiaAlea/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteSaskiaAlea(int id)
        {
            var saskiaAlea = await _saskiaAleaService.GetSaskiaAlea(id);
            if (saskiaAlea == null)
            {
                return NotFound();
            }

            await _saskiaAleaService.DeleteSaskiaAlea(saskiaAlea);

            return NoContent();
        }

        private bool SaskiaAleaExists(int id)
        {
            return _saskiaAleaService.SaskiaAleaExists(id);
        }
    }
}
