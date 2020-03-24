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
        public List<MusicRecord> MusicRecordsList = new List<MusicRecord>();
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
