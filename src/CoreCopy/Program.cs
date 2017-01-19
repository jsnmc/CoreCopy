using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Newtonsoft.Json;
using System.IO;

namespace CoreCopy
{
    public class Program
    {
        public static void Main(string[] args)
        {
            // read file into a string and deserialize JSON to a type
            var x = JsonConvert.DeserializeObject<List<CopyItem>>(File.ReadAllText(@"test.json"));
        }
    }
}
