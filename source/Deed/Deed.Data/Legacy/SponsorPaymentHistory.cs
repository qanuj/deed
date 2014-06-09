namespace Deed.Data.Legacy
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("deedaday_deedaday.sponsor_payment_histories")]
    public partial class SponsorPaymentHistory
    {
        public int id { get; set; }

        public int sponsors_id { get; set; }

        public float payment_amount { get; set; }

        public int student_id { get; set; }

        [Column(TypeName = "timestamp")]
        public DateTime payment_date { get; set; }

        public int sponsorships_id { get; set; }

        [Required]
        [StringLength(100)]
        public string transaction_id { get; set; }

        public sbyte status { get; set; }
    }
}
