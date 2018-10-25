using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using TestProject.Helpers;
using TestProject.Models;

namespace TestProject.Db
{
    public class DataBaseContext : DbContext, IDbContext
    {
        public DbSet<RequestModel> RequestModels { get; set; }


        public DataBaseContext() : base(AppHelper.GetConnectionString())
        {

        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {         
            modelBuilder.Entity<RequestModel>().ToTable("Requests");
            modelBuilder.Entity<RequestModel>().HasKey(x => x.Index);
            modelBuilder.Entity<RequestModel>().Property(x => x.Index).HasColumnName("Index");
        }
    }
}