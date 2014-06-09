namespace Deed.Data.Legacy
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("deedaday_deedaday.clients")]
    public partial class Client
    {
        public int id { get; set; }

        [Required]
        [StringLength(100)]
        public string first_name { get; set; }

        [Required]
        [StringLength(100)]
        public string last_name { get; set; }

        [Required]
        [StringLength(100)]
        public string primary_email { get; set; }

        [Required]
        [StringLength(100)]
        public string login_user_id { get; set; }

        [Required]
        [StringLength(50)]
        public string password { get; set; }

        [Required]
        [StringLength(25)]
        public string mobile { get; set; }

        public sbyte status { get; set; }

        public DateTime created { get; set; }

        public DateTime last_login { get; set; }

        public int login_attempts { get; set; }

        public DateTime unlocktime { get; set; }

        [Required]
        [StringLength(50)]
        public string pdaccept { get; set; }
    }
}
