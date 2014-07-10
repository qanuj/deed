using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Deed.Web.ViewModels
{
    public class StoryViewModel
    {

        public long  StoryId { get; set; }
        public string  StoryTitle { get; set; }
        public string StoryImage { get; set; }
        public string  StoryContent { get; set; }
        public DateTime  CreatedOn { get; set; }
        public long  CreatedBy { get; set; }

    }
}