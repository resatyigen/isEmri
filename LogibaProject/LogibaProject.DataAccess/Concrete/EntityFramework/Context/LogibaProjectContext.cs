using LogibaProject.Entities.Concrete;
using LogibaProject.Entities.Mapping;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogibaProject.DataAccess.Concrete.EntityFramework.Context
{
    public class LogibaProjectContext:DbContext
    {
        public LogibaProjectContext() : base("LogibaProjectContext")
        {
            Database.SetInitializer<LogibaProjectContext>(null);
            Configuration.LazyLoadingEnabled = false;
        }

        //public LogibaProjectContext() : base("LogibaProjectContext") { }

        public DbSet<Admin> Admins { get; set; }

        public DbSet<User> Users { get; set; }

        public DbSet<Group> Groups { get; set; }

        public DbSet<Work> Works { get; set; }

        public DbSet<MapGroupUser> MapGroupUser { get; set; }

        public DbSet<MapWork> MapWork { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.Add(new AdminMap());
            modelBuilder.Configurations.Add(new UserMap());
            modelBuilder.Configurations.Add(new GroupMap());
            modelBuilder.Configurations.Add(new MapGroupUserMap());
            modelBuilder.Configurations.Add(new WorkMap());
            modelBuilder.Configurations.Add(new MapWorkMap());

            base.OnModelCreating(modelBuilder);
        }
    }
}
