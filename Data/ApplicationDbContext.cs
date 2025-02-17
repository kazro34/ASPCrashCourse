using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using ASPCrashCourse.Models;

namespace ASPCrashCourse.Data;

public class ApplicationDbContext : IdentityDbContext
{
    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
        : base(options)
    {
    }

public DbSet<ASPCrashCourse.Models.Joke> Joke { get; set; } = default!;
}
