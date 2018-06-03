using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace encyclopedia_database.Tables
{
    [Table("street")]
    public class Street
    {
        [System.ComponentModel.DataAnnotations.Key]
        [Column("idStreet")]

        public int IdStreet { get; set; }

        public string NewNameStreet { get; set; }

        public string OldNameStreet { get; set; }

        public DateTime FoundingDateStreet { get; set; }
    }
}
