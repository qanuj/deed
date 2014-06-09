namespace Deed.Data.Legacy
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("deedaday_deedaday.forgotpass_requests")]
    public partial class ForgotPassRequest
    {
        public int id { get; set; }

        public int client_id { get; set; }

        [Required]
        [StringLength(200)]
        public string login_id { get; set; }

        [Required]
        [StringLength(100)]
        public string request_ip { get; set; }

        public sbyte status { get; set; }

        public DateTime created { get; set; }
    }
}
