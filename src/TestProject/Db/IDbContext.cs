using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestProject.Models;

namespace TestProject.Db
{
    public interface IDbContext
    {
        int SaveChanges();
        DbSet<RequestModel> RequestModels { get; set; }
    }
}
