namespace Deed.Data.Legacy
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("deedaday_deedaday.currencies")]
    public partial class Currency
    {
        public int id { get; set; }

        [Required]
        [StringLength(255)]
        public string title { get; set; }

        [Required]
        [StringLength(215)]
        public string description { get; set; }

        [Required]
        [StringLength(40)]
        public string symbol { get; set; }

        public float rate { get; set; }

        [Column(TypeName = "timestamp")]
        public DateTime created { get; set; }

        public int created_by { get; set; }

        [Column(TypeName = "timestamp")]
        public DateTime modified { get; set; }

        public int modified_by { get; set; }

        public sbyte status { get; set; }
    }
}
