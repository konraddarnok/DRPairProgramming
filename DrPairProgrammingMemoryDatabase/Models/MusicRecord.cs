using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DrPairProgrammingMemoryDatabase.Models
{
    public class MusicRecord
    {

        private string _recordTitle;
        private double _recordDuration;
        private int _yearOfPuplication;
        private Artist _artist;
        private long _id;

        public enum _genre
        {
            jazz,
            rock,
            pop,
            alternative,
            classic,
            HipHop

        }



        public MusicRecord(long id,string recordTitle, Artist artist, double recordDuration, int yearOfPuplication, _genre genre)
        {
            Id = id;
            RecordTitle = recordTitle;
            Artist = artist;
            recordDuration = recordDuration;
            YearOfPublication = yearOfPuplication;
           _genre Genre = genre;
        }

        public MusicRecord() { }
       


        public string RecordTitle
        {
            get { return _recordTitle; }
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    string e = "Title must be at least 1 character long";
                    throw new ArgumentException(e);
                }
                _recordTitle = value;
            }
        }


        public Artist Artist
        {
            get { return _artist; }
            set
            {   if (value == null)
                {
                    string e = "Artist must exist with a name, a country and a recordlabel";
                    throw new ArgumentNullException(e);
                }

                _artist = value;
            }
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

        public long Id { get => _id; set => _id = value; }
    }
}





