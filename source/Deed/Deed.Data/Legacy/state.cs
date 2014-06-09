namespace Deed.Data.Legacy
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("deedaday_deedaday.states")]
    public partial class State
    {
        public int id { get; set; }

        [Required]
        [StringLength(215)]
        public string name { get; set; }
    }
}
