using Microsoft.AspNet.Identity.EntityFramework;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace slnMyStudy.Models
{
    public class ApplicationDbContext : IdentityDbContext<CustomUser>
    {
        public ApplicationDbContext() : base("DefaultConnection", throwIfV1Schema: false)
        {
        }
        public static ApplicationDbContext Create()
        {
            return new ApplicationDbContext();
        }
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            //這必需在第一行
            base.OnModelCreating(modelBuilder);
            //以下依實際情境來調整 table name
            modelBuilder.Entity<CustomUser>().ToTable("CustomUsers");
            modelBuilder.Entity<IdentityRole>().ToTable("CustomRoles");
            modelBuilder.Entity<IdentityUserRole>().ToTable("CustomUserRoles");
            modelBuilder.Entity<IdentityUserClaim>().ToTable("CustomUserClaims");
            modelBuilder.Entity<IdentityUserLogin>().ToTable("CustomUserLogins");
        }

        public System.Data.Entity.DbSet<slnMyStudy.Models.test> tests { get; set; }
    }
}
