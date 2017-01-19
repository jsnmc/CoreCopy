using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CoreCopy
{
    public class CopyItem
    {
        public string source { get; set; }
        public string dest { get; set; }
        public List<string> include { get; set; }
        public List<string> exclude { get; set; }
        public bool overwrite { get; set; }
    }

    //    {
    //  "source": null,
    //  "dest": null,
    //  "include": null,
    //  "exclude": null,
    //  "overwrite": false
    //}

}
