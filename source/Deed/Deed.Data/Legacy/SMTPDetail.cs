namespace Deed.Data.Legacy
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("deedaday_deedaday.smtp_details")]
    public partial class SMTPDetail
    {
        public int id { get; set; }

        [Required]
        [StringLength(100)]
        public string port_no { get; set; }

        [Required]
        [StringLength(100)]
        public string username { get; set; }

        [Required]
        [StringLength(55)]
        public string password { get; set; }

        [Required]
        [StringLength(255)]
        public string host { get; set; }

        [Required]
        [StringLength(255)]
        public string server_adderss { get; set; }

        public int created_by { get; set; }

        public DateTime created { get; set; }

        public DateTime modified { get; set; }

        public int modified_by { get; set; }

        public sbyte status { get; set; }
    }
}
