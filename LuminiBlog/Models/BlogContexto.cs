using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using LuminiBlog.Models.Identity;
using Microsoft.AspNetCore.Identity;

namespace LuminiBlog.Models
{
    public class BlogContexto : IdentityDbContext<User, Role, int,
                                                   IdentityUserClaim<int>, UserRole, IdentityUserLogin<int>,
                                                   IdentityRoleClaim<int>, IdentityUserToken<int>>
    {
        public BlogContexto(DbContextOptions<BlogContexto> options) : base(options)
        {
        }
        public DbSet<Usuario> Usuarios { get; set; }
        public DbSet<Post> Posts { get; set; }
        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.Entity<Usuario>().HasKey(m => m.Id);
            base.OnModelCreating(builder);

            builder.Entity<Post>().HasKey(m => m.Id);
            base.OnModelCreating(builder);
        }
    }
}
