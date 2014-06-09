namespace Deed.Data.Legacy
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("deedaday_deedaday.sponsorships")]
    public partial class Sponsorship
    {
        public int id { get; set; }

        public int category_id { get; set; }

        [Required]
        [StringLength(255)]
        public string name { get; set; }

        [Column(TypeName = "text")]
        [Required]
        [StringLength(65535)]
        public string content { get; set; }

        [Required]
        [StringLength(500)]
        public string image { get; set; }

        public float amount { get; set; }

        [Column(TypeName = "timestamp")]
        public DateTime created { get; set; }

        public int created_by { get; set; }

        [Column(TypeName = "date")]
        public DateTime modified { get; set; }

        public int modified_by { get; set; }

        public sbyte status { get; set; }
    }
}
