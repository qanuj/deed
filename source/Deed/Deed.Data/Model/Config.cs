using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Deed.Data.Model
{
    public class Config
    {
        public long ID { get; set; }
        public string Hosts { get; set; }//csv
        public string Data { get; set; }//JSON
    }
}
