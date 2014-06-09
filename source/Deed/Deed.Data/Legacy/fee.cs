namespace Deed.Data.Legacy
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("deedaday_deedaday.fees")]
    public partial class Fee
    {
        public int id { get; set; }

        public int student_id { get; set; }

        public double school_fees { get; set; }

        public double uniform_and_book { get; set; }

        public int year { get; set; }

        public double bus_fare { get; set; }

        public double total_per_month { get; set; }

        public double total_per_year { get; set; }

        public sbyte version_status { get; set; }

        public double total_per_halfyear { get; set; }

        [Required]
        [StringLength(10)]
        public string admin_percent { get; set; }

        public DateTime created { get; set; }

        public int created_by { get; set; }
    }
}
