namespace Deed.Data.Legacy
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("deedaday_deedaday.user_permissions")]
    public partial class UserPermission
    {
        public int id { get; set; }

        public int group_id { get; set; }

        public int module_id { get; set; }

        public int action_id { get; set; }

        public int created_by { get; set; }

        public DateTime created { get; set; }

        public DateTime modified { get; set; }

        public int modified_by { get; set; }
    }
}
