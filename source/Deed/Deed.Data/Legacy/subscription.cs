namespace Deed.Data.Legacy
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("deedaday_deedaday.subscriptions")]
    public partial class Subscription
    {
        public int id { get; set; }

        [Required]
        [StringLength(225)]
        public string pack_name { get; set; }

        public double price { get; set; }

        public bool controls { get; set; }

        public bool additional_orders { get; set; }

        public bool opinion_products_included { get; set; }

        public bool seal { get; set; }

        public bool certificate { get; set; }

        public bool mediation { get; set; }

        public bool live_statistics { get; set; }

        public bool improved_seo { get; set; }

        public bool free_trial { get; set; }

        public bool no_time_commitment { get; set; }

        public bool social_interaction { get; set; }

        [Column(TypeName = "enum")]
        [Required]
        [StringLength(65532)]
        public string status { get; set; }
    }
}
