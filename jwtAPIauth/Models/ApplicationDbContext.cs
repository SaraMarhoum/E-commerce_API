using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace jwtAPIauth.Models
{
    public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
        }

        public virtual DbSet<Product> Products { get; set; }
        public virtual DbSet<Command> Commands { get; set; }
        public virtual DbSet<Category> Categories { get; set; }
        public virtual DbSet<Cart> Carts { get; set; }
        public virtual DbSet<ProductInCommand> ProductInCommands { get; set; }
        public virtual DbSet<ProductInCart> ProductInCarts { get; set; }


        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.Entity<ProductInCommand>()
           .HasKey(e => new { e.CommandID, e.ProductID });

            builder.Entity<ProductInCommand>()
            .HasOne<Product>(e => e.Products)
            .WithMany(p => p.ProductInCommands);

            builder.Entity<ProductInCommand>()
            .HasOne<Command>(e => e.Commands)
            .WithMany(p => p.ProductInCommands);



            builder.Entity<ProductInCart>()
            .HasKey(e => new { e.CartID, e.ProductID });

            builder.Entity<ProductInCart>()
            .HasOne<Product>(e => e.Products)
            .WithMany(p => p.ProductInCarts);

            builder.Entity<ProductInCart>()
            .HasOne<Cart>(e => e.Carts)
            .WithMany(p => p.ProductInCarts);


            builder.Entity<Category>().HasKey(c => c.CatID);

            base.OnModelCreating(builder);

        }
    }
}
