namespace Deed.Data.Legacy
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("deedaday_deedaday.plans")]
    public partial class Plan
    {
        public int id { get; set; }

        [Required]
        [StringLength(64)]
        public string name { get; set; }

        public double price { get; set; }

        [Column(TypeName = "enum")]
        [Required]
        [StringLength(65532)]
        public string status { get; set; }
    }
}
