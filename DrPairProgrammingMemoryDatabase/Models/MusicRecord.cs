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

        //private enum _genre
        //{
        //    jazz,
        //    rock,
        //    pop,
        //    alternative,
        //    classic,
        //    HipHop
        //}

        public MusicRecord(long id, string recordTitle, Artist artist, double recordDuration, int yearOfPuplication/*, int genre*/)
        {
            Id = id;
            RecordTitle = recordTitle;
            Artist = artist;
            RecordDuration = recordDuration;
            YearOfPublication = yearOfPuplication;
            //Genre = genre;
            //Genre skal rettes eller fjernes eller gøres til en separat klasse. Hvis vi tænker i tabeller, bør artist have id
        }

        public MusicRecord() { }

       // public enum Genre { jazz, rock, pop, alternative, classic,HipHop }
        
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
            {
                if (value == null)
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





