namespace Deed.Data.Legacy
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("deedaday_deedaday.cms")]
    public partial class Cms
    {
        public int id { get; set; }

        [Required]
        [StringLength(225)]
        public string alias { get; set; }

        [Required]
        [StringLength(225)]
        public string title { get; set; }

        [Column(TypeName = "text")]
        [Required]
        [StringLength(65535)]
        public string tags { get; set; }

        [Required]
        [StringLength(225)]
        public string permalink { get; set; }

        public int version_number { get; set; }

        [Column(TypeName = "text")]
        [Required]
        [StringLength(65535)]
        public string content { get; set; }

        public int category_id { get; set; }

        [Required]
        [StringLength(215)]
        public string image { get; set; }

        public int created_by { get; set; }

        public DateTime created { get; set; }

        public sbyte status { get; set; }

        [Required]
        [StringLength(225)]
        public string token { get; set; }
    }
}
