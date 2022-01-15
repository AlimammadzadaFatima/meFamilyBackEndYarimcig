using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace meFamilyBackEnd.Models
{
    public class DataContext:DbContext
    {
        public DataContext(DbContextOptions <DataContext> options):base (options)
        {

        }
        public DbSet<Story> Stories { get; set; }
        public DbSet<Worker> Workers { get; set; }
        public DbSet<Setting> Settings { get; set; }
        public DbSet<SosialMedia> SosialMedias { get; set; }
        public DbSet<WorkerSocialMedia> WorkerMedias { get; set; }
    }
}
