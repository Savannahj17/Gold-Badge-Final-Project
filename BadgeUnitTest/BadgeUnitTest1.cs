using BadgeClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;

namespace BadgeUnitTest
{
    [TestClass]
    public class BadgeUnitTest1
    {
        BadgeRepo _badgeRepo;
        Badge badge;

        [TestInitialize]
        public void Arrange()
        {
            _badgeRepo = new BadgeRepo();
            badge = new Badge(1234, "Badge1", new List<string>() { "Door1", "Door2"});
        }
        [TestMethod]
        public void AddBadgeToDirectory_Test()
        {
            Badge badge = new Badge();
            bool value = _badgeRepo.AddBadgeToDirectory(badge);
            Assert.IsTrue(value);
        }

        [TestMethod]
        public void GetDoorsById_Test()
        {
            _badgeRepo.AddBadgeToDirectory(badge);
            List<string> doors = _badgeRepo.GetDoorsById(badge.BadgeId);
            bool door1 = doors.Contains("Door1");
            bool door2 = doors.Contains("Door2");
            Assert.IsTrue(door1 && door2);
        }

        [TestMethod]
        public void UpdateDoorsOnExistingBadge_Test()
        {
            List<string> newDoors = new List<string> { "Door3" };
            _badgeRepo.AddBadgeToDirectory(badge);
            bool value = _badgeRepo.UpdateDoorsOnExistingBadge(badge.BadgeId, newDoors);
            Assert.IsTrue(value);
        }
        [TestMethod]
        public void DeleteDoorsFromBadge_Test()
        {
            int badgeId = badge.BadgeId;
            _badgeRepo.AddBadgeToDirectory(badge);
            bool value = _badgeRepo.DeleteDoorsFromBadge(badgeId);
            Assert.IsTrue(value);
        }
    }
}

//Where does my method exist ? - arrange 
//what argument does it take? - arrange
//what objects need to exist to test this method