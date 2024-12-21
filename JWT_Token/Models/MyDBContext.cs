using Microsoft.EntityFrameworkCore;

namespace JWT_Token.Models
{
    public class MyDBContext : DbContext
    {
        public MyDBContext() { }

        public MyDBContext(DbContextOptions<MyDBContext> options) : base(options) { }

        // Corrected DbSet initialization
        public virtual DbSet<Employee> Employee { get; set; } = null!;
        public virtual DbSet<tblDLP> tblDLP { get; set; } = null!;

        
    }
}
