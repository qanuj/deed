namespace Deed.Data.Legacy
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("deedaday_deedaday.client_payment_details")]
    public partial class PaymentDetails
    {
        public int id { get; set; }

        public int client_payment_id { get; set; }

        public int client_id { get; set; }

        public int student_id { get; set; }

        public float amount { get; set; }

        public DateTime created { get; set; }
    }
}
