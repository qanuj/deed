namespace Deed.Data.Legacy
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("deedaday_deedaday.student_payment_details")]
    public partial class StudentPaymentDetails
    {
        public int id { get; set; }

        public int client_id { get; set; }

        public int student_id { get; set; }

        public int client_payment_id { get; set; }

        public float total_payment { get; set; }

        [Required]
        [StringLength(10)]
        public string payment_mode { get; set; }

        public float first_instalment { get; set; }

        [Required]
        [StringLength(250)]
        public string currency { get; set; }

        public double currency_rate { get; set; }

        public DateTime payment_date { get; set; }

        [Column(TypeName = "date")]
        public DateTime renewal_first_date { get; set; }

        [Column(TypeName = "date")]
        public DateTime renewal_second_date { get; set; }

        [Column(TypeName = "date")]
        public DateTime renewal_third_date { get; set; }

        public sbyte sponsor_status { get; set; }

        public DateTime sponsor_deactive_date { get; set; }

        public int sponsor_deactive_by { get; set; }

        public sbyte payment_status { get; set; }
    }
}
