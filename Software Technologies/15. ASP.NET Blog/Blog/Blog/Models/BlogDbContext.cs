using Microsoft.AspNet.Identity.EntityFramework;

namespace Blog.Models
{

    public class ApplicationDbContext : IdentityDbContext<BlogDbContext>
    {
        public ApplicationDbContext()
            : base("DefaultConnection", throwIfV1Schema: false)
        {
        }

        public static ApplicationDbContext Create()
        {
            return new ApplicationDbContext();
        }
    }
}