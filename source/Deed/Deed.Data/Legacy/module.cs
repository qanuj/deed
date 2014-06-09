namespace Deed.Data.Legacy
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("deedaday_deedaday.modules")]
    public partial class Module
    {
        public int id { get; set; }

        [Required]
        [StringLength(100)]
        public string name { get; set; }

        public sbyte status { get; set; }
    }
}
