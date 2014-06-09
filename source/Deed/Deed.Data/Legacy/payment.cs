namespace Deed.Data.Legacy
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("deedaday_deedaday.payments")]
    public partial class Payment
    {
        public int id { get; set; }

        public int subscription_id { get; set; }

        public DateTime purchase_date { get; set; }

        [Column(TypeName = "enum")]
        [Required]
        [StringLength(65532)]
        public string payment_status { get; set; }

        public int transaction_id { get; set; }

        public double amount_paid { get; set; }

        [Required]
        [StringLength(32)]
        public string currency { get; set; }

        [Required]
        [StringLength(125)]
        public string payer_email { get; set; }

        public DateTime payment_date { get; set; }

        public DateTime current_date { get; set; }
    }
}
