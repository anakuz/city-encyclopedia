using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace encyclopedia_database.Tables
{
    [Table("background")]
    public class Background
    {
        [System.ComponentModel.DataAnnotations.Key]
        [Column("idBackground")]

        public int IdBackground { get; set; }

        public string SourceBackground { get; set; }

        public DateTime YearBackground { get; set; }

        public string ContentsBackground { get; set; }

        public int IdSight { get; set; }
    }
}
