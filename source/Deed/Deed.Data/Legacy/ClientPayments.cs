namespace Deed.Data.Legacy
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("deedaday_deedaday.client_payments")]
    public partial class ClientPayments
    {
        public int id { get; set; }

        public int client_id { get; set; }

        [Required]
        [StringLength(100)]
        public string transaction_number { get; set; }

        public double amount { get; set; }

        public double total_amount { get; set; }

        [Required]
        [StringLength(10)]
        public string payment_mode { get; set; }

        [Required]
        [StringLength(250)]
        public string currency { get; set; }

        public double currency_rate { get; set; }

        [Required]
        [StringLength(15)]
        public string payment_type { get; set; }

        public int payment_status { get; set; }

        public int no_of_student { get; set; }

        [Required]
        [StringLength(200)]
        public string bank_name { get; set; }

        [Required]
        [StringLength(50)]
        public string cheque_no { get; set; }

        [Required]
        [StringLength(100)]
        public string reciept { get; set; }

        public sbyte payment_for { get; set; }

        public DateTime payment_date { get; set; }

        public DateTime exp_date { get; set; }

        public DateTime created { get; set; }

        public int created_by { get; set; }

        [Column(TypeName = "enum")]
        [Required]
        [StringLength(65532)]
        public string client_type { get; set; }
    }
}
