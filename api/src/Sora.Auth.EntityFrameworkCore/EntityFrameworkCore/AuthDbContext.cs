using Abp.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace Sora.Auth.EntityFrameworkCore
{
    public class AuthDbContext : AbpDbContext
    {
        //Add DbSet properties for your entities...

        public AuthDbContext(DbContextOptions<AuthDbContext> options) 
            : base(options)
        {

        }
    }
}
