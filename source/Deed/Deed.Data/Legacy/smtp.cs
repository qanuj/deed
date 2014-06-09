namespace Deed.Data.Legacy
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("deedaday_deedaday.smtps")]
    public partial class SMTP
    {
        public int id { get; set; }

        [Required]
        [StringLength(255)]
        public string smtp_host { get; set; }

        [Required]
        [StringLength(255)]
        public string smtp_user { get; set; }

        [Required]
        [StringLength(255)]
        public string smtp_password { get; set; }

        [Required]
        [StringLength(255)]
        public string smtp_port { get; set; }

        [Required]
        [StringLength(255)]
        public string smtp_name { get; set; }

        [Required]
        [StringLength(255)]
        public string smtp_reply { get; set; }

        [Required]
        [StringLength(255)]
        public string smtp_bounce { get; set; }

        public short smtp_status { get; set; }

        public int pos { get; set; }
    }
}
