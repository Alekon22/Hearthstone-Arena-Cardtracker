using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Yeoltest
{
    // ["Basic","Blackrock Mountain","Classic","Credits","Curse of Naxxramas","Debug","Goblins vs Gnomes","Missions","Promotion","Reward","System"]
    public class AllSets
    {
        public List<HearthstoneObject> Basic { get; set; }
        [JsonProperty("Blackrock Mountain")]
        public List<HearthstoneObject> BlackrockMountain { get; set; }
        public List<HearthstoneObject> Classic { get; set; }
        public List<HearthstoneObject> Credits { get; set; }
        [JsonProperty("Curse of Naxxramas")]
        public List<HearthstoneObject> CurseOfNaxxramas { get; set; }
        public List<HearthstoneObject> Debug { get; set; }
        [JsonProperty("Goblins vs Gnomes")]
        public List<HearthstoneObject> GvG { get; set; }
        public List<HearthstoneObject> Missions { get; set; }
        public List<HearthstoneObject> Promotions { get; set; }
        public List<HearthstoneObject> Reward { get; set; }
        public List<HearthstoneObject> System { get; set; }
    }
}
