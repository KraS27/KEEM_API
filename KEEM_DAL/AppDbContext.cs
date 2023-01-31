using KEEM_Models.Tables;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KEEM_DAL
{
    public class AppDbContext : DbContext
    {
        public DbSet<Poi> Pois { get; set; } 

        public AppDbContext(DbContextOptions options) : base(options) 
        {

        }
    }
}
