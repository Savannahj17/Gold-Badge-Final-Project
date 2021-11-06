using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BadgeClassLibrary
{
    public class Badge
    {
        public int BadgeId { get; set; }
        public List<string> DoorNames { get; set; }

        public string BadgeName { get; set; }

        public Badge()
        {

        }

        public Badge(int badgeId, string badgeName, List<string> doorNames)
        {
            BadgeId = badgeId;
            BadgeName = badgeName;
            DoorNames = doorNames;
        }
    }
}