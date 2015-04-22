using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Hs_Arena_Tracker.Models
{
    public class HearthstoneObject
    {
        public string name { get; set; }
        public int cost { get; set; }
        public string type { get; set; }
        public string rarity { get; set; }
        public string faction { get; set; }
        public string race { get; set; }
        public string playerClass { get; set; }
        public string text { get; set; }
        public string inPlayText { get; set; }
        public List<string> mechanics { get; set; }
        public string flavor { get; set; }
        public string artist { get; set; }
        public int attack { get; set; }
        public int health { get; set; }
        public int durability { get; set; }
        public string id { get; set; }
        public bool collectible { get; set; }
        public bool elite { get; set; }
        public string howToGet { get; set; }
        public string howToGetGold { get; set; }
    }
}
