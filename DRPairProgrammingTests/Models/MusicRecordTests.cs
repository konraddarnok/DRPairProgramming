using Microsoft.VisualStudio.TestTools.UnitTesting;
using DRPairProgramming.Models;
using System;
using System.Collections.Generic;
using System.Text;
using DRPairProgramming.Controllers;

namespace DRPairProgramming.Models.Tests
{
    [TestClass()]
    public class MusicRecordTests
    {

        [TestMethod(), ExpectedException(typeof(ArgumentException))]
        public void TitleNullException()
        {
            MusicRecord record1 = new MusicRecord("", new Artist("Madonna", "Sony", "America"), 25.45, 1999,
                MusicRecord._genre.pop);
        }

        [TestMethod()]
        public void MusicRecordTest1()
        {
            MusicRecord record2 = new MusicRecord("MyMusic", new Artist("Madonna", "Sony", "America"), 25.45, 1999,
                MusicRecord._genre.pop);
            Assert.AreEqual(record2.Artist.ArtistName, "Madonna");
            Assert.AreNotEqual(record2.YearOfPublication, 2001);
        }

        [TestMethod()]
        public void TestGetMethods()
        {
            MusicRecordController controller = new MusicRecordController();

            controller.Get();

            Assert.AreEqual(controller.MusicRecordsList.Count, 3);
            Assert.AreNotEqual(controller.MusicRecordsList.Count, 2);
        }

        [TestMethod()]
        public void TestPostMethods()
        {
            MusicRecordController controller = new MusicRecordController();
            int currentCount = controller.MusicRecordsList.Count;
            int afterPost = currentCount + 1;

            controller.Post(new MusicRecord("MyMusicTest", new Artist("Eminem", "Empire Records", "USA"), 123.4, 2020,
                MusicRecord._genre.jazz));
            Assert.AreEqual(controller.MusicRecordsList.Count, afterPost);

        }
    }
}