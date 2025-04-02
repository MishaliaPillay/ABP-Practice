using Microsoft.EntityFrameworkCore;
using System.Data.Common;

namespace PracticeProject.EntityFrameworkCore;

public static class PracticeProjectDbContextConfigurer
{
    public static void Configure(DbContextOptionsBuilder<PracticeProjectDbContext> builder, string connectionString)
    {
        builder.UseSqlServer(connectionString);
    }

    public static void Configure(DbContextOptionsBuilder<PracticeProjectDbContext> builder, DbConnection connection)
    {
        builder.UseSqlServer(connection);
    }
}
