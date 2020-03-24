using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using DRPairProgramming.Models;



namespace DRPairProgramming.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MusicRecordController : ControllerBase
    {
        public List<MusicRecord> MusicRecordsList = new List<MusicRecord>()
        {
            new MusicRecord ("titel1", new Artist("artistname1", "recordLavel1", "country1"), 22.22, 22, MusicRecord._genre.alternative),
            new MusicRecord ("titel2", new Artist("artistname2", "recordLavel2", "country2"), 33.33, 33, MusicRecord._genre.classic),
             new MusicRecord ("titel3", new Artist("artistname3", "recordLavel3", "country3"), 44.44, 44, MusicRecord._genre.HipHop)
        };

        

        // GET: api/MusicRecord
        [HttpGet]
        public IEnumerable<MusicRecord> Get()
        {
            return MusicRecordsList;
        }

        // GET: api/MusicRecord/5
        [HttpGet("{id}", Name = "Get")]
        public MusicRecord Get(int id)
        {
            return MusicRecordsList[id];
        }

        // POST: api/MusicRecord
        [HttpPost]
        public void Post([FromBody] MusicRecord value)
        {
            MusicRecordsList.Add(value);
        }

        // PUT: api/MusicRecord/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE: api/ApiWithActions/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
