namespace Deed.Data.Legacy
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("deedaday_deedaday.documents")]
    public partial class Document
    {
        public int id { get; set; }

        public int student_id { get; set; }

        [Column("document", TypeName = "text")]
        [Required]
        [StringLength(65535)]
        public string document1 { get; set; }
    }
}
