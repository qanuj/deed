namespace Deed.Data.Legacy
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("deedaday_deedaday.backup_details")]
    public partial class BackupDetail
    {
        public int id { get; set; }

        [Required]
        [StringLength(30)]
        public string serial_id { get; set; }

        [Column(TypeName = "text")]
        [Required]
        [StringLength(65535)]
        public string db { get; set; }

        [Column(TypeName = "text")]
        [Required]
        [StringLength(65535)]
        public string image { get; set; }

        [Column(TypeName = "text")]
        [Required]
        [StringLength(65535)]
        public string code { get; set; }

        public sbyte status { get; set; }

        public DateTime created { get; set; }
    }
}
