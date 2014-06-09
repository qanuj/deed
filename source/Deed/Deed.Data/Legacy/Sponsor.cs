namespace Deed.Data.Legacy
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("deedaday_deedaday.sponsors")]
    public partial class Sponsor
    {
        public int id { get; set; }

        [Required]
        [StringLength(215)]
        public string first_name { get; set; }

        [Required]
        [StringLength(215)]
        public string last_name { get; set; }

        [Required]
        [StringLength(500)]
        public string address_line1 { get; set; }

        [Required]
        [StringLength(500)]
        public string address_line2 { get; set; }

        [Required]
        [StringLength(500)]
        public string city { get; set; }

        [Required]
        [StringLength(215)]
        public string state { get; set; }

        [Required]
        [StringLength(500)]
        public string country { get; set; }

        [Required]
        [StringLength(500)]
        public string zip { get; set; }

        public int status { get; set; }

        [Column(TypeName = "timestamp")]
        public DateTime created { get; set; }

        [Column(TypeName = "timestamp")]
        public DateTime modified { get; set; }

        [Required]
        [StringLength(50)]
        public string phone { get; set; }

        [Required]
        [StringLength(50)]
        public string mobile { get; set; }

        [Required]
        [StringLength(255)]
        public string amount_word { get; set; }

        public float amount_figure { get; set; }

        [Required]
        [StringLength(500)]
        public string email { get; set; }

        public int created_by { get; set; }

        public int modified_by { get; set; }
    }
}
