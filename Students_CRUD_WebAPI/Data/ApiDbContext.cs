namespace Students_CRUD_WebAPI.Data
{
    using Microsoft.EntityFrameworkCore;
    using Students_CRUD_WebAPI.Models;

    public class ApiDbContext : DbContext
    {
        public ApiDbContext(DbContextOptions<ApiDbContext> options)
        : base(options)
        {
        }

        public DbSet<StudentModel> StudentModel { get; set; }
    }

    
}




