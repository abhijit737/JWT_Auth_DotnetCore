using JWT_Dotnet.Models;
using Microsoft.EntityFrameworkCore;

namespace JWT_Dotnet.Context
{
    public class ApplicationDBContext:DbContext
    {
        public ApplicationDBContext(DbContextOptions<ApplicationDBContext>options):base(options)
        {
                
        }
        public virtual DbSet<User> User { get; set; }

        }
}
