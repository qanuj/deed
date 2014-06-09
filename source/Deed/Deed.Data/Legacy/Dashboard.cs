namespace Deed.Data.Legacy
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("deedaday_deedaday.dashbord_datas")]
    public partial class Dashboard
    {
        public int id { get; set; }

        public int item_id { get; set; }

        [Required]
        [StringLength(250)]
        public string subject { get; set; }

        [Required]
        [StringLength(250)]
        public string subject2 { get; set; }

        public long today { get; set; }

        [Required]
        [StringLength(200)]
        public string percentage { get; set; }

        public long yesterday { get; set; }

        public long this_month { get; set; }

        public long last_month { get; set; }

        public long all_time { get; set; }

        public DateTime created { get; set; }
    }
}
