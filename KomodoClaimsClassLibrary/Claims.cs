 using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KomodoClaimsClassLibrary
{
    public enum ClaimType
    {
        Car = 1,
        Home,
        Theft
    }
    public class Claims
    {
        public int ClaimId { get; set; }
        public ClaimType TypeOfClaim { get; set; }
        public string Description { get; set; }
        public int ClaimAmount { get; set; }
        public int DateOfIncident { get; set; }
        public int DateOfClaim { get; set; }
        public bool IsValid { get; set; }

        public Claims()
        {

        }
        public Claims(int claimId, ClaimType claimType, string description, int claimAmount, int dateOfIncident, int dateOfClaim, bool isValid)
        {
            ClaimId = claimId;
            //ClaimType = TypeOfClaim;
            Description = description;
            ClaimAmount = claimAmount;
            DateOfIncident = dateOfIncident;
            DateOfClaim = dateOfClaim;
            IsValid = isValid;
        }
    }
}
