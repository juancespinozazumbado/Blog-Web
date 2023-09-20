
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace GuanaBlog.Infraestructure.Identity
{
    public class PostIdentityContext : IdentityDbContext<PostUser>
    {
        public PostIdentityContext(DbContextOptions<PostIdentityContext> options) : base(options) { }
    }
}
