namespace Deed.Data.Legacy
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("deedaday_deedaday.students")]
    public partial class Student
    {
        public int id { get; set; }

        [Required]
        [StringLength(215)]
        public string first_name { get; set; }

        [Required]
        [StringLength(215)]
        public string last_name { get; set; }

        public short male { get; set; }

        [Required]
        [StringLength(500)]
        public string address_line1 { get; set; }

        [Required]
        [StringLength(500)]
        public string city { get; set; }

        [Required]
        [StringLength(500)]
        public string state { get; set; }

        [Required]
        [StringLength(500)]
        public string country { get; set; }

        [Required]
        [StringLength(500)]
        public string zip { get; set; }

        [Required]
        [StringLength(500)]
        public string middle_name { get; set; }

        [Required]
        [StringLength(500)]
        public string father_middle_name { get; set; }

        [Required]
        [StringLength(500)]
        public string mother_middle_name { get; set; }

        [Column(TypeName = "text")]
        [Required]
        [StringLength(65535)]
        public string image { get; set; }

        public int status { get; set; }

        public DateTime created { get; set; }

        public DateTime modified { get; set; }

        [Required]
        [StringLength(215)]
        public string father_first_name { get; set; }

        [Required]
        [StringLength(215)]
        public string father_last_name { get; set; }

        [Required]
        [StringLength(215)]
        public string mother_first_name { get; set; }

        [Required]
        [StringLength(215)]
        public string mother_last_name { get; set; }

        [Column(TypeName = "date")]
        public DateTime date_of_birth { get; set; }

        [Required]
        [StringLength(150)]
        public string phone1 { get; set; }

        [Required]
        [StringLength(150)]
        public string phone2 { get; set; }

        [Required]
        [StringLength(500)]
        public string email { get; set; }

        [Column(TypeName = "text")]
        [Required]
        [StringLength(65535)]
        public string family_history { get; set; }

        [Required]
        [StringLength(215)]
        public string religion { get; set; }

        public int cast_id { get; set; }

        [Required]
        [StringLength(215)]
        public string post_office { get; set; }

        [Required]
        [StringLength(215)]
        public string police_station { get; set; }

        [Required]
        [StringLength(215)]
        public string tehsil { get; set; }

        [Required]
        [StringLength(215)]
        public string village { get; set; }

        [Required]
        [StringLength(215)]
        public string district { get; set; }

        public int clas_id { get; set; }

        [Required]
        [StringLength(500)]
        public string address_line2 { get; set; }

        public int created_by { get; set; }

        public int modified_by { get; set; }

        public sbyte priority { get; set; }

        public sbyte sponsor_status { get; set; }

        public int student_payment_detail_id { get; set; }
    }
}
