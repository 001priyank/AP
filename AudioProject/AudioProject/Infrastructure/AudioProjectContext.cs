using Microsoft.EntityFrameworkCore;
using AudioProject.Entities;
using Microsoft.EntityFrameworkCore.Internal;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using AudioProject.Entities.Orders;
using AudioProject.Entities.OrderManagement;

namespace AudioProject.Infrastructure
{
    public class AudioProjectContext : DbContext
    {      
        public DbSet<User> Users { get; set; }
        public DbSet<Role> Roles { get; set; }
        public DbSet<UserRole> UserRoles { get; set; }
        public DbSet<Error> Errors { get; set; }
        public DbSet<OrderTypes> OrderTypes { get; set; }
        public DbSet<OrderTypeCategorys> OrderTypeCategorys { get; set; }
        public DbSet<OrderTypeDescriptions> OrderTypeDescriptions { get; set; }

        public DbSet<Orders> Orders { get; set; }
        public DbSet<OrderItems> OrderItems { get; set; }
        public DbSet<OrderFiles> OrderFiles { get; set; }


        public AudioProjectContext(DbContextOptions options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            foreach (var entity in modelBuilder.Model.GetEntityTypes())
            {
                entity.Relational().TableName = entity.DisplayName();
            }

            //// Photos
            //modelBuilder.Entity<Photo>().Property(p => p.Title).HasMaxLength(100);
            //modelBuilder.Entity<Photo>().Property(p => p.AlbumId).IsRequired();

            //// Album
            //modelBuilder.Entity<Album>().Property(a => a.Title).HasMaxLength(100);
            //modelBuilder.Entity<Album>().Property(a => a.Description).HasMaxLength(500);
            //modelBuilder.Entity<Album>().HasMany(a => a.Photos).WithOne(p => p.Album);

            // Order TYpe category
            modelBuilder.Entity<OrderTypeCategorys>().Property(u => u.CategoryName).IsRequired().HasMaxLength(100);
            modelBuilder.Entity<OrderTypeCategorys>().Property(u => u.CategoryDescription).IsRequired().HasMaxLength(100);
            modelBuilder.Entity<OrderTypeCategorys>().Property(u => u.IsActive);
            modelBuilder.Entity<OrderTypeCategorys>().Property(u => u.SortOrder);
            modelBuilder.Entity<OrderTypeCategorys>().Property(u => u.IsVisible);
            modelBuilder.Entity<OrderTypeCategorys>().HasMany<OrderTypes>(u => u.OrderTypes).WithOne(u => u.OrderTypeCategory).HasForeignKey(u => u.OrderTypeCategoryId);

            //Order types
            modelBuilder.Entity<OrderTypes>().Property(u => u.IsActive);
            modelBuilder.Entity<OrderTypes>().Property(u => u.IsVisible);
            modelBuilder.Entity<OrderTypes>().Property(u => u.SortOrder);
            modelBuilder.Entity<OrderTypes>().Property(u => u.OrderTypeDisplayName).IsRequired().HasMaxLength(100);
            modelBuilder.Entity<OrderTypes>().Property(u => u.OrderTypeName).IsRequired().HasMaxLength(100);
            modelBuilder.Entity<OrderTypes>().Property(u => u.Price).IsRequired();
            modelBuilder.Entity<OrderTypes>().Property(u => u.PriceFuture);
            modelBuilder.Entity<OrderTypes>().HasMany<OrderTypeDescriptions>(u => u.OrderTypeDescriptions).WithOne(u => u.OrderType).HasForeignKey(u => u.OrderTypeId);

            // Order description
            modelBuilder.Entity<OrderTypeDescriptions>().Property(u => u.IsActive);
            modelBuilder.Entity<OrderTypeDescriptions>().Property(u => u.IsVisible);
            modelBuilder.Entity<OrderTypeDescriptions>().Property(u => u.SortOrder);
            modelBuilder.Entity<OrderTypeDescriptions>().Property(u => u.Description);

            // Orders

            modelBuilder.Entity<Orders>().Property(u => u.OrderStatus);
            modelBuilder.Entity<Orders>().Property(u => u.UserId);            
            modelBuilder.Entity<Orders>().HasMany<OrderFiles>(u => u.OrderFiles).WithOne(u => u.Order).HasForeignKey(u => u.OrderId);
            modelBuilder.Entity<Orders>().HasMany<OrderItems>(u => u.OrderItems).WithOne(u => u.Order).HasForeignKey(u => u.OrderId);

            // Order Items
            modelBuilder.Entity<OrderItems>().Property(u => u.OrderId).IsRequired();
            modelBuilder.Entity<OrderItems>().Property(u => u.OrderStatus);
            modelBuilder.Entity<OrderItems>().Property(u => u.OrderTypeId);

            //Order Files
            modelBuilder.Entity<OrderFiles>().Property(u => u.OrderId).IsRequired();
            modelBuilder.Entity<OrderFiles>().Property(u => u.FileName);

            // User
            modelBuilder.Entity<User>().Property(u => u.Username).IsRequired().HasMaxLength(100);
            modelBuilder.Entity<User>().Property(u => u.Email).IsRequired().HasMaxLength(200);
            modelBuilder.Entity<User>().Property(u => u.HashedPassword).IsRequired().HasMaxLength(200);
            modelBuilder.Entity<User>().Property(u => u.Salt).IsRequired().HasMaxLength(200);

            // UserRole
            modelBuilder.Entity<UserRole>().Property(ur => ur.UserId).IsRequired();
            modelBuilder.Entity<UserRole>().Property(ur => ur.RoleId).IsRequired();

            // Role
            modelBuilder.Entity<Role>().Property(r => r.Name).IsRequired().HasMaxLength(50);
        }
    }
}
