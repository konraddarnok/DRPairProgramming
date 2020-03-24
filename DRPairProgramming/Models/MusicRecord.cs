using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DRPairProgramming.Models
{
    public class MusicRecord : Artist
    {
        
        private string _recordTitle;    
        private double _recordDuration;
        private int _yearOfpoplication;
        private Artist _artist;
        
        public MusicRecord(string recordTitle, Artist artist, double recordDuration, int yearOfpoplication) 
        {
            RecordTitle = recordTitle;
        }
        public string RecordTitle
        {
            get
            {
                return _recordTitle;
            }
            set
            {
                _recordTitle = value;
            }

        }
        

    }
}
