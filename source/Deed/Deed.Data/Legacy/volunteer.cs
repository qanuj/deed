namespace Deed.Data.Legacy
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("deedaday_deedaday.volunteers")]
    public partial class Volunteer
    {
        public int id { get; set; }

        public int client_id { get; set; }

        [Required]
        [StringLength(215)]
        public string subject { get; set; }

        [Column(TypeName = "text")]
        [Required]
        [StringLength(65535)]
        public string message { get; set; }

        [Required]
        [StringLength(215)]
        public string ip { get; set; }

        [Column(TypeName = "timestamp")]
        public DateTime created { get; set; }
    }
}
