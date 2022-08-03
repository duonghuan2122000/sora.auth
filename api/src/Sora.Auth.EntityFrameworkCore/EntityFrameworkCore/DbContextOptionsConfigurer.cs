using Microsoft.EntityFrameworkCore;

namespace Sora.Auth.EntityFrameworkCore
{
    public static class DbContextOptionsConfigurer
    {
        public static void Configure(
            DbContextOptionsBuilder<AuthDbContext> dbContextOptions, 
            string connectionString
            )
        {
            /* This is the single point to configure DbContextOptions for AuthDbContext */
            dbContextOptions.UseSqlServer(connectionString);
        }
    }
}
