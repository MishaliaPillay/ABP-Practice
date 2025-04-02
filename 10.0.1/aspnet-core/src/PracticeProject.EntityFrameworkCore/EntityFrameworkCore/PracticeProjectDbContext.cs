using Abp.Zero.EntityFrameworkCore;
using PracticeProject.Authorization.Roles;
using PracticeProject.Authorization.Users;
using PracticeProject.MultiTenancy;
using Microsoft.EntityFrameworkCore;

namespace PracticeProject.EntityFrameworkCore;

public class PracticeProjectDbContext : AbpZeroDbContext<Tenant, Role, User, PracticeProjectDbContext>
{
    /* Define a DbSet for each entity of the application */

    public PracticeProjectDbContext(DbContextOptions<PracticeProjectDbContext> options)
        : base(options)
    {
    }
}
