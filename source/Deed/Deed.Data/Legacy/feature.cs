namespace Deed.Data.Legacy
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("deedaday_deedaday.features")]
    public partial class Feature
    {
        public int id { get; set; }

        [Required]
        [StringLength(64)]
        public string name { get; set; }
    }
}
