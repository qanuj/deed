namespace Deed.Data.Legacy
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("deedaday_deedaday.bank_payment_statustrans")]
    public partial class BankPaymentStatusTrans
    {
        public int id { get; set; }

        public int pay_id { get; set; }

        public short client_id { get; set; }

        [Column(TypeName = "enum")]
        [Required]
        [StringLength(65532)]
        public string type { get; set; }

        [Column(TypeName = "enum")]
        [Required]
        [StringLength(65532)]
        public string bank_type { get; set; }

        [Required]
        [StringLength(250)]
        public string txnresult { get; set; }

        [Required]
        [StringLength(250)]
        public string txnpaymentid { get; set; }

        [Required]
        [StringLength(250)]
        public string txnref { get; set; }

        [Required]
        [StringLength(250)]
        public string txntranid { get; set; }

        [Required]
        [StringLength(250)]
        public string txnamount { get; set; }

        [Column(TypeName = "text")]
        [Required]
        [StringLength(65535)]
        public string txnerror { get; set; }

        [StringLength(125)]
        public string terminalid { get; set; }

        public DateTime created { get; set; }
    }
}
