using GuanaBlog.Core.Domain.Entitis;
using Microsoft.EntityFrameworkCore;


namespace GuanaBlog.Infraestructure.Data
{
    public class PostDbContext : DbContext
    {
        public PostDbContext(DbContextOptions<PostDbContext> options) : base(options) { }


        public DbSet<Post> Posts { get; set; }
        public DbSet<PostComment> PostCommnenst {  get; set; }  
    }
}
