namespace Deed.Data.Legacy
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("deedaday_deedaday.client_remiders")]
    public partial class ClientRemiders
    {
        public int id { get; set; }

        public short client_id { get; set; }

        [Required]
        [StringLength(55)]
        public string name { get; set; }

        [Required]
        [StringLength(55)]
        public string primary_email { get; set; }

        public DateTime created { get; set; }
    }
}
