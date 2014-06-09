namespace Deed.Data.Legacy
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("deedaday_deedaday.groups")]
    public partial class Group
    {
        public int id { get; set; }

        [Required]
        [StringLength(100)]
        public string name { get; set; }

        public sbyte status { get; set; }

        public int created_by { get; set; }

        public DateTime created { get; set; }

        public DateTime modified { get; set; }

        public int modified_by { get; set; }
    }
}
