namespace Deed.Data.Legacy
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("deedaday_deedaday.invite_friends")]
    public partial class InviteFriends
    {
        public int id { get; set; }

        public int client_id { get; set; }

        [Required]
        [StringLength(215)]
        public string email1 { get; set; }

        [Required]
        [StringLength(215)]
        public string email2 { get; set; }

        [Required]
        [StringLength(215)]
        public string email3 { get; set; }

        [Required]
        [StringLength(215)]
        public string email4 { get; set; }

        [Required]
        [StringLength(215)]
        public string email5 { get; set; }

        [Column(TypeName = "text")]
        [Required]
        [StringLength(65535)]
        public string message { get; set; }

        [Column(TypeName = "timestamp")]
        public DateTime created { get; set; }
    }
}
