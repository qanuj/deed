namespace Deed.Data.Legacy
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("deedaday_deedaday.users")]
    public partial class User
    {
        public int id { get; set; }

        [Required]
        [StringLength(100)]
        public string username { get; set; }

        [Required]
        [StringLength(100)]
        public string password { get; set; }

        [Required]
        [StringLength(100)]
        public string first_name { get; set; }

        [Required]
        [StringLength(100)]
        public string last_name { get; set; }

        [Required]
        [StringLength(100)]
        public string email { get; set; }

        public sbyte status { get; set; }

        public int group_id { get; set; }

        public int created_by { get; set; }

        public DateTime created { get; set; }

        public DateTime modifiedmodified { get; set; }

        public int modified_by { get; set; }

        public DateTime last_login { get; set; }

        public int login_attempts { get; set; }

        public DateTime unlocktime { get; set; }
    }
}
