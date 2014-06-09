namespace Deed.Data.Legacy
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("deedaday_deedaday.module_actions")]
    public partial class ModuleAction
    {
        public int id { get; set; }

        public int module_id { get; set; }

        public int user_action_id { get; set; }
    }
}
