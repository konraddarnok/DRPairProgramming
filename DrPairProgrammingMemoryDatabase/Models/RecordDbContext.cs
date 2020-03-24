using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;


namespace DrPairProgrammingMemoryDatabase.Models
{
        public class RecordDbContext : DbContext
        {
            
            public RecordDbContext(DbContextOptions<RecordDbContext> options)
                : base(options)
            {
             
            }

            public DbSet<MusicRecord> RecordDb { get; set; }
        
        }

}
