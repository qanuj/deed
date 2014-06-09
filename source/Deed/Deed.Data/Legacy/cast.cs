namespace Deed.Data.Legacy
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("deedaday_deedaday.casts")]
    public partial class Cast
    {
        public int id { get; set; }

        [Required]
        [StringLength(250)]
        public string name { get; set; }

        public DateTime created { get; set; }

        public int created_by { get; set; }
    }
}
