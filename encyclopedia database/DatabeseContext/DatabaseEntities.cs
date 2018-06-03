using System.Data.Entity;
using encyclopedia_database.Tables;
using MySql.Data.Entity;

namespace encyclopedia_database.DatabeseContext
{
    [DbConfigurationType(typeof(MySqlEFConfiguration))]
    public class DatabaseEntities : DbContext
    {
        public DatabaseEntities() : base("name=mydbConnectionString") { }

        public DbSet<Street> Street { get; set; }

        public DbSet<Square> Square { get; set; }

        public DbSet<Sight> Sight { get; set; }

        public DbSet<Background> Background { get; set; }
    }
}
