using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Worksheet.Data
{
    public class WorksheetContext : DbContext
    {
        public WorksheetContext() : base("DbConnection"){

        }

        public DbSet<User> Users { get; set; }
        public DbSet<Answer> Answers { get; set; }
        public DbSet<Standing> Standings { get; set; }
        public DbSet<OneEighth> OneEighths { get; set; }
        public DbSet<OneQuarter> OneQuarters { get; set; }
        public DbSet<Semifinal> Semifinals { get; set; }
        public DbSet<ThirdPlace> ThirdPlaces { get; set; }
        public DbSet<Final> Finals { get; set; }
    }
}
