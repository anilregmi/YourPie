using Microsoft.EntityFrameworkCore;

namespace YourPie.Models
{
    public class YourPieDbContext:DbContext
    {
        public YourPieDbContext(DbContextOptions<YourPieDbContext> options) : base(options) { } 
        public  DbSet<Category> Categories { get; set; }    
        public  DbSet<Pie>  pies { get; set; }
    }
}
