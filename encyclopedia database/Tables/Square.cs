using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace encyclopedia_database.Tables
{
    [Table("square")]
    public class Square
    {
        [System.ComponentModel.DataAnnotations.Key]
        [Column("idSquare")]

        public int IdSquare { get; set; }

        public string NewNameSquare { get; set; }

        public string OldNameSquare { get; set; }

        public DateTime FoundingDateSquare { get; set; }
    }
}
