using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Slamty.Core.Entities;

namespace Slamty.Infrastracture.Persistence.DashboardIdentity
{
    public class DashboardIdentityDbContext : IdentityDbContext<DashboardUser>
    {
        public DashboardIdentityDbContext(DbContextOptions options) : base(options)
        {
        }
    }
}
