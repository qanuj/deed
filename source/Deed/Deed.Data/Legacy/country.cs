namespace Deed.Data.Legacy
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("deedaday_deedaday.countries")]
    public partial class Country
    {
        public int id { get; set; }

        [Required]
        [StringLength(128)]
        public string name { get; set; }

        [Required]
        [StringLength(2)]
        public string iso_code_2 { get; set; }

        [Required]
        [StringLength(3)]
        public string iso_code_3 { get; set; }

        [Column(TypeName = "text")]
        [Required]
        [StringLength(65535)]
        public string address_format { get; set; }

        public int status { get; set; }
    }
}
