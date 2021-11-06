using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KomodoClaimsClassLibrary
{
    public class ClaimsRepo
    {


        protected readonly Queue<Claims> _claimQueue = new Queue<Claims>();

        public bool AddClaimToDirectory(Claims claim)
        {
            int startingCount = _claimQueue.Count;
            _claimQueue.Enqueue(claim);

            bool wasAdded = _claimQueue.Count > startingCount ? true : false;
            return wasAdded;

        }

        public Queue<Claims> GetAllContents()
        {
            return _claimQueue;
        }

        public Claims GetClaimById(int claimId)
        {

            foreach (Claims claim in _claimQueue)
            {
                if (claim.ClaimId == claimId)
                {
                    return claim;
                }
            }
            return null;
        }

        public bool UpdateExistingClaim(int claimId, Claims newClaim)
        {
            Claims oldClaim = GetClaimById(claimId);
            if (oldClaim != null)
            {
                oldClaim.ClaimId = newClaim.ClaimId;
                oldClaim.ClaimAmount = newClaim.ClaimAmount;
                oldClaim.DateOfClaim = newClaim.DateOfClaim;
                oldClaim.DateOfIncident = newClaim.DateOfIncident;
               
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool DeleteExistingClaim(Claims existingClaim)
        {
            int count1 = _claimQueue.Count;
            _claimQueue.Dequeue();
            if(_claimQueue.Count == count1 - 1)
            {
                return true;
            }
            return false;
        }
    }
}
 