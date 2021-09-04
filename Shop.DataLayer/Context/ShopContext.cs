using Microsoft.EntityFrameworkCore;
using Shop.DataLayer.Entities;
using Shop.DataLayer.Entities.Permission;
using Shop.DataLayer.Entities.Product;
using Shop.DataLayer.Entities.User;
using Shop.DataLayer.Entities.Wallet;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shop.DataLayer.Context
{
    public class ShopContext : DbContext
    {
        public ShopContext(DbContextOptions<ShopContext> options) : base(options)
        {

        }

        #region User

        public DbSet<Role> Roles { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<UserRole> UserRoles { get; set; }
        public DbSet<UserDiscountCode> UserDiscountCodes { get; set; }

        #endregion
        #region Wallet
        public DbSet<WalletType> WalletTypes { get; set; }
        public DbSet<Wallet> Wallets { get; set; }
        #endregion
        #region Permission

        public DbSet<Permission> Permission { get; set; }
        public DbSet<RolePermission> RolePermission { get; set; }

        #endregion
        #region Product

        public DbSet<ProductCategory> ProductCategories { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<ProductFile> ProductFiles { get; set; }
        public DbSet<UserProduct> UserProducts { get; set; }
        public DbSet<ProductComment> ProductComments { get; set; }
        #endregion
        #region Order

        public DbSet<Order> Orders { get; set; }
        public DbSet<OrderDetail> OrderDetails { get; set; }
        public DbSet<Discount> Discounts { get; set; }

        #endregion
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<User>().HasQueryFilter(u => !u.IsDelete);
            modelBuilder.Entity<Role>().HasQueryFilter(r => !r.IsDelete);
            modelBuilder.Entity<ProductCategory>().HasQueryFilter(g => !g.IsDelete);
            modelBuilder.Entity<Product>().HasQueryFilter(p => !p.IsDelete);
            modelBuilder.Entity<Product>().HasOne<ProductCategory>(p => p.ProductCategory).WithMany(p => p.Products).HasForeignKey(c => c.CategoryId);
            modelBuilder.Entity<Product>().HasOne<ProductCategory>(c => c.Category).WithMany(s => s.SubCategory).HasForeignKey(f => f.SubCategory);
            base.OnModelCreating(modelBuilder);
            
        }
    }
}
