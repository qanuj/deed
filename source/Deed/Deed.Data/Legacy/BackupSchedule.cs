namespace Deed.Data.Legacy
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("deedaday_deedaday.backup_schedules")]
    public partial class BackupSchedule
    {
        public int id { get; set; }

        public sbyte db { get; set; }

        public sbyte image { get; set; }

        public sbyte code { get; set; }

        public sbyte status { get; set; }

        [Required]
        [StringLength(100)]
        public string schedule_time { get; set; }

        public int schedule_day { get; set; }

        public DateTime created { get; set; }

        public int created_by { get; set; }

        [Column(TypeName = "text")]
        [Required]
        [StringLength(65535)]
        public string db_to { get; set; }

        [Column(TypeName = "text")]
        [Required]
        [StringLength(65535)]
        public string image_from { get; set; }

        [Column(TypeName = "text")]
        [Required]
        [StringLength(65535)]
        public string image_to { get; set; }

        [Column(TypeName = "text")]
        [Required]
        [StringLength(65535)]
        public string code_from { get; set; }

        [Column(TypeName = "text")]
        [Required]
        [StringLength(65535)]
        public string code_to { get; set; }
    }
}
