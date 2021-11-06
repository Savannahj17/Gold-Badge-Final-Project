using KomodoClaimsClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;

namespace KomodoClaimsUnitTest
{
    [TestClass]
    public class ClaimsUnitTest1
    {
        ClaimsRepo _claimsRepo;
        Claims claim;

        [TestInitialize]
        public void Arrange()
        {
            _claimsRepo = new ClaimsRepo();
            claim = new Claims(12345, ClaimType.Home, "House Fire", 5000, 1103, 1103, true);
            _claimsRepo.AddClaimToDirectory(claim);
        }

        [TestMethod]
        public void AddClaimToQueue_Test()
        {
            Claims claim = new Claims();
            bool value = _claimsRepo.AddClaimToDirectory(claim);
            Assert.IsTrue(value);
        }

        [TestMethod]
        public void GetAllContents_Test()
        {
            Queue<Claims> queue =_claimsRepo.GetAllContents();
            Assert.IsNotNull(queue);
        }

        [TestMethod]
        public void GetClaimById_Test()
        {
            Claims claim = _claimsRepo.GetClaimById(12345);
            Assert.IsNotNull(claim);
        }

        [TestMethod]
        public void UpdateExistingClaim_Test()
        {
            
           Claims  claim2 = new Claims(678910, ClaimType.Car, "Flat Tire", 200, 1115, 1116, false);
            bool wasFound = _claimsRepo.UpdateExistingClaim(12345, claim2);
            Assert.IsTrue(wasFound);
        }
    }
}
//Where does my method exist ? - arrange 
//what argument does it take? - arrange