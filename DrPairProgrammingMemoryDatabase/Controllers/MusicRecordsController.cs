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
        private readonly RecordDbContext _context;
        private readonly List<MusicRecord> DummyData = new List<MusicRecord>{
                new MusicRecord(1,"titel1", new Artist(1,"artistname1", "recordLavel1", "country1"), 22.22, 22, MusicRecord._genre.alternative),
                new MusicRecord(2,"titel2", new Artist(2,"artistname2", "recordLavel2", "country2"), 33.33, 33, MusicRecord._genre.classic),
                new MusicRecord(3,"titel3", new Artist(3,"artistname3", "recordLavel3", "country3"), 44.44, 44, MusicRecord._genre.HipHop)};


    public MusicRecordsController(RecordDbContext context)
        {
            _context = context;

        }

        // GET: api/MusicRecords
        [HttpGet]
        public async Task<ActionResult<IEnumerable<MusicRecord>>> GetRecordDb()
        {
            return DummyData;
            //return await _context.RecordDb.ToListAsync();
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
