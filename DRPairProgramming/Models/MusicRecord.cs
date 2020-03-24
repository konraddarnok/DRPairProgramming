using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DRPairProgramming.Models
{
    public class MusicRecord
    {

        private string _recordTitle;
        private double _recordDuration;
        private int _yearOfPuplication;
        private Artist _artist;
        public enum _genre
        {
            jazz,
            rock,
            pop,
            alternative,
            classic,
            HipHop

        }



        public MusicRecord(string recordTitle, Artist artist, double recordDuration, int yearOfPuplication, _genre genre)
        {
            RecordTitle = recordTitle;
            Artist = artist;
            recordDuration = recordDuration;
            YearOfPublication = yearOfPuplication;
           _genre Genre = genre;
        }

        public string RecordTitle
        {
            get { return _recordTitle; }
            set { _recordTitle = value; }
        }


        public Artist Artist
        {
            get { return _artist; }
            set { _artist = value; }
        }

        public double RecordDuration
        {
            get { return _recordDuration; }
            set { _recordDuration = value; }
        }

        public int YearOfPublication
        {
            get { return _yearOfPuplication; }
            set { _yearOfPuplication = value; }
        }
        
    }
}





