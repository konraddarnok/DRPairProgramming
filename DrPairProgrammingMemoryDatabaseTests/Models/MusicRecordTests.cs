using Microsoft.VisualStudio.TestTools.UnitTesting;
using DrPairProgrammingMemoryDatabase.Models;
using DrPairProgrammingMemoryDatabase.Controllers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.EntityFrameworkCore;

namespace DrPairProgrammingMemoryDatabase.Models.Tests
{
    [TestClass()]
    public class MusicRecordTests
    {
      RecordDbContext offlineDB = new RecordDbContext(new DbContextOptions<RecordDbContext> ());

     

        [TestMethod(), ExpectedException(typeof(ArgumentException))]
            public void TitleNullException()
            {
                MusicRecord record1 = new MusicRecord(1, "",new Artist(4, "Madonna", "Sony", "America"), 25.45, 1999);
            }

            [TestMethod()]
            public void MusicRecordTest1()
            {
                MusicRecord record2 = new MusicRecord(2,"MyMusic", new Artist(4,"Madonna", "Sony", "America"), 25.45, 1999);
                Assert.AreEqual(record2.Artist.ArtistName, "Madonna");
                Assert.AreNotEqual(record2.YearOfPublication, 2001);
            }

            [TestMethod()]
            public void TestGetMethods()
            {
                MusicRecordsController controller = new MusicRecordsController(offlineDB);

            controller.GetRecordDb();

                Assert.AreEqual(controller.GetRecordDb().Result.Value.Count(), 3);
                Assert.AreNotEqual(controller.GetRecordDb().Result.Value.Count(), 2);
            }

            [TestMethod()]
            public void TestPostMethods()
            {
                MusicRecordsController controller = new MusicRecordsController(offlineDB);
                int currentCount = controller.GetRecordDb().Result.Value.Count();
                int afterPost = currentCount + 1;

                controller.PostMusicRecord(new MusicRecord(77,"MyMusicTest", new Artist(66,"Eminem", "Empire Records", "USA"), 123.4, 2020));
                Assert.AreEqual(controller.GetRecordDb().Result.Value.Count(), afterPost);

            }
        }
    }