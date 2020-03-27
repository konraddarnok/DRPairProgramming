using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using DrPairProgrammingMemoryDatabase.Models;

namespace DrPairProgrammingMemoryDatabase.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MusicRecordsController : ControllerBase
    {
        private RecordDbContext _context;

        private MusicRecord m1 = new MusicRecord(1, "album1", new Artist(1, "Don", "Label1", "denmark"), 22.33, 2010);

    public MusicRecordsController(RecordDbContext context)
        {
            
            _context = context;
         
        }

        // GET: api/MusicRecords
        [HttpGet]
        public async Task<ActionResult<IEnumerable<MusicRecord>>> GetRecordDb()
        {
            PostMusicRecord(m1);
            return await _context.RecordDb.ToListAsync();
        }

        // GET: api/MusicRecords/5
        [HttpGet("{id}")]
        public async Task<ActionResult<MusicRecord>> GetMusicRecord(long id)
        {
            var musicRecord = await _context.RecordDb.FindAsync(id);

            if (musicRecord == null)
            {
                return NotFound();
            }

            return musicRecord;
        }

        // PUT: api/MusicRecords/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for
        // more details see https://aka.ms/RazorPagesCRUD.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutMusicRecord(long id, MusicRecord musicRecord)
        {
            if (id != musicRecord.Id)
            {
                return BadRequest();
            }

            _context.Entry(musicRecord).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!MusicRecordExists(id))
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

        // POST: api/MusicRecords
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for
        // more details see https://aka.ms/RazorPagesCRUD.
        [HttpPost]
        public async Task<ActionResult<MusicRecord>> PostMusicRecord(MusicRecord musicRecord)
        {
            _context.RecordDb.Add(musicRecord);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetMusicRecord", new { id = musicRecord.Id }, musicRecord);
        }

        // DELETE: api/MusicRecords/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<MusicRecord>> DeleteMusicRecord(long id)
        {
            var musicRecord = await _context.RecordDb.FindAsync(id);
            if (musicRecord == null)
            {
                return NotFound();
            }

            _context.RecordDb.Remove(musicRecord);
            await _context.SaveChangesAsync();

            return musicRecord;
        }

        private bool MusicRecordExists(long id)
        {
            return _context.RecordDb.Any(e => e.Id == id);
        }
    }
}
