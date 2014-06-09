namespace Deed.Data.Legacy
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("deedaday_deedaday.general_settings")]
    public partial class GeneralSetting
    {
        public int id { get; set; }

        [Required]
        [StringLength(225)]
        public string module { get; set; }

        [Required]
        [StringLength(225)]
        public string alias { get; set; }

        [Column(TypeName = "text")]
        [Required]
        [StringLength(65535)]
        public string value { get; set; }

        public DateTime current_date { get; set; }

        [Column(TypeName = "enum")]
        [Required]
        [StringLength(65532)]
        public string status { get; set; }
    }
}
