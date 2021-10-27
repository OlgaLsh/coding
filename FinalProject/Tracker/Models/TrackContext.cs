using Models.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class TrackContext:DbContext

    {
        public TrackContext(): base("Data Source=LAPTOP-ERGTETKJ\\SQLEXPRESS;Initial Catalog=TrackerDb;Integrated Security=True")
        {

        }
        public DbSet<User> Users => Set<User>();

        public DbSet<Tip> Tips => Set<Tip>();

        public DbSet<UserProgress> UserProgresses => Set<UserProgress>();

    }
}
