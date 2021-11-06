using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BadgeClassLibrary
{
    public class BadgeRepo
    {
        private Dictionary<int, List<string>> _badgeDictionary = new Dictionary<int, List<string>>();
        private List<Badge> _badges = new List<Badge>();

        public bool AddBadgeToDirectory(Badge badge)
        {
            int dictStartingCount = _badgeDictionary.Count;
            int listStartingCount = _badges.Count;
            _badgeDictionary.Add(badge.BadgeId, badge.DoorNames);
            _badges.Add(badge);//list
            bool dictWasAdded = _badgeDictionary.Count > dictStartingCount ? true : false;
            bool listWasAdded = _badges.Count > listStartingCount ? true : false;//list count comparison
            if (dictWasAdded && listWasAdded)
            {
                return true;
            }
            return false;
        }
        public Dictionary<int, List<string>> GetAllBadges()
        {
            return _badgeDictionary;
        }

        public List<string> GetDoorsById(int badgeId)
        {
            foreach (KeyValuePair<int, List<string>> kvp in _badgeDictionary)
            {
                if (badgeId == kvp.Key)
                {
                    return kvp.Value;
                }
            }
            return null;
        }

        public Badge GetBadgeById(int badgeId)
        {
            foreach (Badge badgeItem in _badges)
            {
                if (badgeItem.BadgeId == badgeId)
                {
                    return badgeItem;
                }
            }
            return null;
        }


        public bool UpdateDoorsOnExistingBadge(int badgeId, List<string> newDoors)
        {
            Badge badge = GetBadgeById(badgeId);
            if (badge != null)
            {
                foreach (KeyValuePair<int, List<string>> kvp in _badgeDictionary)
                {
                    if (badgeId == kvp.Key)
                    {
                        bool value = _badgeDictionary.Remove(badgeId);
                        if (value == true)
                        {
                            _badgeDictionary.Add(badgeId, newDoors);
                            return true;
                        }
                    }
                }
                badge.DoorNames = newDoors;
                return true;
            }
            else
            {
                return false;
            }

        }


        public bool DeleteDoorsFromBadge(int badgeId)
        {
            bool deletedDoor = false;
            List<string> newDoors = new List<string>();
            foreach (KeyValuePair<int, List<string>> kvp in _badgeDictionary)
            {
                if (badgeId == kvp.Key)
                {
                    deletedDoor = _badgeDictionary.Remove(badgeId);
                    if (deletedDoor == true)
                    {
                        _badgeDictionary.Add(badgeId, newDoors);
                    }
                    return deletedDoor;
                }
            }
            return deletedDoor;
        }
    }
}
