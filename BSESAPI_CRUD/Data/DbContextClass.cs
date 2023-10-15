using BSESAPI_CRUD.Entities;
using Microsoft.EntityFrameworkCore;

namespace BSESAPI_CRUD.Data
{
    public class DbContextClass:DbContext
    {
        public DbContextClass(DbContextOptions<DbContextClass> options ) : base(options)
        {
            
        }

        public DbSet<ConsumerInfromation> ConsumerInformations { get; set; }
    }
}
