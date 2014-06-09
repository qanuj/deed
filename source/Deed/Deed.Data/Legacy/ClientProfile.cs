namespace Deed.Data.Legacy
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("deedaday_deedaday.client_profiles")]
    public partial class ClientProfile
    {
        public int id { get; set; }

        public int client_id { get; set; }

        [Required]
        [StringLength(100)]
        public string secondry_email { get; set; }

        [Column(TypeName = "date")]
        public DateTime dob { get; set; }

        [Required]
        [StringLength(15)]
        public string office_phone { get; set; }

        [Required]
        [StringLength(15)]
        public string home_phone { get; set; }

        [Column(TypeName = "text")]
        [Required]
        [StringLength(65535)]
        public string address_line1 { get; set; }

        [Column(TypeName = "text")]
        [Required]
        [StringLength(65535)]
        public string address_line2 { get; set; }

        [Required]
        [StringLength(100)]
        public string city { get; set; }

        [Required]
        [StringLength(100)]
        public string state { get; set; }

        [Required]
        [StringLength(100)]
        public string country { get; set; }

        [Required]
        [StringLength(20)]
        public string zip { get; set; }

        [Column(TypeName = "text")]
        [Required]
        [StringLength(65535)]
        public string photo { get; set; }

        [Required]
        [StringLength(100)]
        public string pledge { get; set; }

        public sbyte alert_on { get; set; }

        public sbyte newsletter_on { get; set; }

        public sbyte emergency_on { get; set; }

        public DateTime created { get; set; }

        public DateTime modified { get; set; }

        public int created_by { get; set; }

        public int modified_by { get; set; }
    }
}
