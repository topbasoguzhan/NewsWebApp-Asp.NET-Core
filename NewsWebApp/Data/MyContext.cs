using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using NewsWebApp.Models.Identity;

namespace NewsWebApp.Data
{
    public class MyContext : IdentityDbContext<ApplicationUser,ApplicationRole,string>
    {
        public MyContext(DbContextOptions<MyContext> options)
           : base(options)
        {

        }
    }
}
