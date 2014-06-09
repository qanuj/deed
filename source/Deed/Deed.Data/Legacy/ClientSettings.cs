namespace Deed.Data.Legacy
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("deedaday_deedaday.client_settings")]
    public partial class ClientSettings
    {
        public int id { get; set; }

        public int client_id { get; set; }

        public DateTime modified { get; set; }

        public sbyte send_ren_rem { get; set; }

        public sbyte send_newsletter { get; set; }

        public sbyte send_urgent_request { get; set; }
    }
}
