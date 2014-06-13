using Microsoft.Build.Framework;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Deed.Web.ViewModels
{
    public class SponsorPaymentViewModel
    {
        public long image_iD { get; set; }
        public string Name { get; set; }
        public List<string> Picture{ get; set; }

        

        public int client_id { get; set; }

        

        
        [StringLength(100)]
        public string client_name { get; set; }

        
        

        
        public string transaction_number { get; set; }

        public double amount { get; set; }

        public double total_amount { get; set; }

        
        public string payment_mode { get; set; }

       
        public string currency { get; set; }

        public double currency_rate { get; set; }

       
        public string payment_type { get; set; }

        public int payment_status { get; set; }

        public int no_of_student { get; set; }

        
        public string bank_name { get; set; }

        
        public string cheque_no { get; set; }

        
        public string reciept { get; set; }

        public sbyte payment_for { get; set; }

        public DateTime payment_date { get; set; }

        public DateTime exp_date { get; set; }

        public DateTime created { get; set; }

        public int created_by { get; set; }

        [Column(TypeName = "enum")]
        
        [StringLength(65532)]
        public string client_type { get; set; }


    }
}