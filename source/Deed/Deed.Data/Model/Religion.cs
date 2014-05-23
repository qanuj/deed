using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Deed.Data.Model
{
    public class Religion : Master
    {

        public long ID { get; set; }

        //[Required(ErrorMessageResourceName = "Required", ErrorMessageResourceType = typeof(System.Data.Entity.Resources.Resource)), Display(Name = "Name", ResourceType = typeof(System.Data.Entity.Resources.Resource)), StringLength(128)]
        public string Name { get; set; }
    }
}
