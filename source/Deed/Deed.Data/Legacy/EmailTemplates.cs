namespace Deed.Data.Legacy
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("deedaday_deedaday.email_templates")]
    public partial class EmailTemplates
    {
        public int id { get; set; }

        [Required]
        [StringLength(250)]
        public string title { get; set; }

        [Required]
        [StringLength(250)]
        public string subject { get; set; }

        [Column(TypeName = "text")]
        [Required]
        [StringLength(65535)]
        public string details { get; set; }

        public int created_by { get; set; }

        public DateTime created { get; set; }

        public DateTime modified { get; set; }

        public int modified_by { get; set; }

        public sbyte status { get; set; }
    }
}
