using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Deed.Data.Model
{
    public class Widget
    {
        public long ID { get; set; }
        public string Title { get; set; }
        //[DataType(DataType.Html)]
        public string Body { get; set; }
        public int Sequence { get; set; }
        public bool IsAll { get; set; }
        public bool IsHome { get; set; }
        public bool IsInternal { get; set; }
        public bool IsSecured { get; set; }
        public bool IsAnonmous { get; set; }
    }
}
