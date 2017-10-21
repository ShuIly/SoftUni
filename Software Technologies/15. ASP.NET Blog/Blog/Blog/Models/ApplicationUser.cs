using System.ComponentModel.DataAnnotations;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;
using System.Security.Claims;
using System.Threading.Tasks;

namespace Blog.Models
{
    // You can add profile data for the user by adding more properties to your BlogDbContext class, please visit https://go.microsoft.com/fwlink/?LinkID=317594 to learn more.
    public class BlogDbContext : IdentityUser
    {
		[Required]
	    public string FullName { get; set; }	

        public async Task<ClaimsIdentity> GenerateUserIdentityAsync(UserManager<BlogDbContext> manager)
        {
            // Note the authenticationType must match the one defined in CookieAuthenticationOptions.AuthenticationType
            var userIdentity = await manager.CreateIdentityAsync(this, DefaultAuthenticationTypes.ApplicationCookie);
            // Add custom user claims here
            return userIdentity;
        }
    }
}