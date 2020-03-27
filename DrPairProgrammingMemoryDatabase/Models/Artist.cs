using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DrPairProgrammingMemoryDatabase.Models
{
    public class Artist
    {
        private string _artistName;
        private string _recordLabel;
        private string _country;
        private int _id;
        
        public string ArtistName { get => _artistName; set => _artistName = value; }
        public string RecordLabel { get => _recordLabel; set => _recordLabel = value; }
        public string Country { get => _country; set => _country = value; }
        public int Id { get => _id; set => _id = value; }

        public Artist(int id, string artistName, string recordLabel, string country)
        {
            ArtistName = artistName;
            RecordLabel = recordLabel;
            Country = country;
        }
    }
}
