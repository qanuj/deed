namespace Deed.Data.Legacy
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("deedaday_deedaday.student_histories")]
    public partial class StudentHistory
    {
        public int id { get; set; }

        public int student_id { get; set; }

        [Required]
        [StringLength(255)]
        public string title { get; set; }

        [Column(TypeName = "text")]
        [Required]
        [StringLength(65535)]
        public string desc { get; set; }

        [Column(TypeName = "timestamp")]
        public DateTime created { get; set; }

        public int created_by { get; set; }

        [Column(TypeName = "timestamp")]
        public DateTime modified { get; set; }

        public int modified_by { get; set; }

        public sbyte status { get; set; }
    }
}
