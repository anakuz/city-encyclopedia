using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace encyclopedia_database.Tables
{
    [Table("sight")]
    public class Sight
    {
        [System.ComponentModel.DataAnnotations.Key]
        [Column("idSight")]

        public int IdSight { get; set; }

        public string NameSight { get; set; }

        public DateTime FoundingDateSight { get; set; }

        public int IdStreet { get; set; }
    }
}