using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace Yeoltest
{
    public class HearthstoneObject
    {
        public string id { get; set; }
        public string name { get; set; }
        public int cost { get; set; }
        public string type { get; set; }
        public string playerClass { get; set; }
        public int attack { get; set; }
        public int health { get; set; }
        public int durability { get; set; }

    }
}
