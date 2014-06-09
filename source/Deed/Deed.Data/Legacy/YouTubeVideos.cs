namespace Deed.Data.Legacy
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("deedaday_deedaday.youtube_videos")]
    public partial class YouTubeVideos
    {
        public int id { get; set; }

        [Required]
        [StringLength(225)]
        public string title { get; set; }

        [Column(TypeName = "text")]
        [Required]
        [StringLength(65535)]
        public string description { get; set; }

        [Column(TypeName = "text")]
        [Required]
        [StringLength(65535)]
        public string link { get; set; }

        public int category { get; set; }

        [Required]
        [StringLength(50)]
        public string show_on_home { get; set; }

        public short status { get; set; }

        public DateTime created { get; set; }

        public int created_by { get; set; }

        public DateTime modified { get; set; }

        public int modified_by { get; set; }
    }
}
