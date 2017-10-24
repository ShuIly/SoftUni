using Microsoft.AspNet.Identity.EntityFramework;

namespace Blog.Models
{

    public class BlogDbContext : IdentityDbContext<BlogDbContext>
    {
        public BlogDbContext()
            : base("DefaultConnection", throwIfV1Schema: false)
        {
        }

        public static ApplicationDbContext Create()
        {
            return new ApplicationDbContext();
        }
    }
}