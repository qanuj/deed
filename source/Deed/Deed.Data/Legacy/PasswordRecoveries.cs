namespace Deed.Data.Legacy
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("deedaday_deedaday.password_recoveries")]
    public partial class PasswordRecoveries
    {
        public int id { get; set; }

        [Required]
        [StringLength(100)]
        public string userid { get; set; }

        [Required]
        [StringLength(100)]
        public string authentication_code { get; set; }

        public sbyte status { get; set; }

        [Required]
        [StringLength(100)]
        public string ip { get; set; }

        public DateTime created { get; set; }
    }
}
