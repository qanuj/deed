namespace Deed.Data.Legacy
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("deedaday_deedaday.clas")]
    public partial class Cla
    {
        public int id { get; set; }

        [Required]
        [StringLength(250)]
        public string name { get; set; }

        public int sort { get; set; }
    }
}
