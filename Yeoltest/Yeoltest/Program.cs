using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Yeoltest
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = System.AppDomain.CurrentDomain.BaseDirectory + "AllSets.json";

            using (StreamReader r = new StreamReader(path))
            {
                string json = r.ReadToEnd();
                
                var hsObjects = JsonConvert.DeserializeObject<List<AllSets>>(json);
                Console.WriteLine("Done!");   
            }
            
        }
    }
}
