namespace Deed.Data.Legacy
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("deedaday_deedaday.phone_codes")]
    public partial class PhoneCodes
    {
        public int id { get; set; }

        [Column(TypeName = "char")]
        [Required]
        [StringLength(2)]
        public string iso { get; set; }

        [Required]
        [StringLength(80)]
        public string name { get; set; }

        [Required]
        [StringLength(80)]
        public string nicename { get; set; }

        [Column(TypeName = "char")]
        [StringLength(3)]
        public string iso3 { get; set; }

        public short? numcode { get; set; }

        public int phonecode { get; set; }
    }
}
