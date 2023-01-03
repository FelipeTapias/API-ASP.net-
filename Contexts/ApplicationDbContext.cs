using Microsoft.EntityFrameworkCore;
using MiPrimerWebAPIM3.Entities;

namespace MiPrimerWebAPIM3.Contexts
{
    public class ApplicationDbContext: DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            :base(options)
        {

        }

        public DbSet<Autor> Autores { get; set; }

    }
}
