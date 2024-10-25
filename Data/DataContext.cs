using Microsoft.EntityFrameworkCore;

namespace EduTrack.Data
{

    public class DataContext: DbContext
    {
        public DataContext(DbContextOptions<DataContext> options): base(options) {
        }
        public DbSet<Course> Courses { get; set; }
        public DbSet<Student> Students { get; set; }
        public DbSet<Register> Registers { get; set; }
    }
}
