using System.Configuration;
using Microsoft.EntityFrameworkCore;

namespace FanshopDbEFCore
{
    public partial class FanshopEFCoreContext : DbContext
    {
        public FanshopEFCoreContext()
        {
        }

        public FanshopEFCoreContext(DbContextOptions<FanshopEFCoreContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Brand> Brand { get; set; }
        public virtual DbSet<Category> Category { get; set; }
        public virtual DbSet<Color> Color { get; set; }
        public virtual DbSet<Customer> Customer { get; set; }
        public virtual DbSet<Order> Order { get; set; }
        public virtual DbSet<OrderProduct> OrderProduct { get; set; }
        public virtual DbSet<OrderStatus> OrderStatus { get; set; }
        public virtual DbSet<Product> Product { get; set; }
        public virtual DbSet<Team> Team { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
                optionsBuilder.UseSqlServer(ConfigurationManager.ConnectionStrings["EFCoreConnection"].ConnectionString);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("ProductVersion", "2.2.6-servicing-10079");

            modelBuilder.Entity<Brand>(entity =>
            {
                entity.HasIndex(e => e.BrandName)
                    .HasName("UQ_Brand_BrandName")
                    .IsUnique();

                entity.Property(e => e.BrandName)
                    .IsRequired()
                    .HasMaxLength(20);
            });

            modelBuilder.Entity<Category>(entity =>
            {
                entity.HasIndex(e => e.CategoryName)
                    .HasName("UQ_Category_CategoryName")
                    .IsUnique();

                entity.Property(e => e.CategoryName)
                    .IsRequired()
                    .HasMaxLength(15);
            });

            modelBuilder.Entity<Color>(entity =>
            {
                entity.HasIndex(e => e.ColorName)
                    .HasName("UQ_Color_ColorName")
                    .IsUnique();

                entity.Property(e => e.ColorName)
                    .IsRequired()
                    .HasMaxLength(15);
            });

            modelBuilder.Entity<Customer>(entity =>
            {
                entity.HasIndex(e => e.Email)
                    .HasName("UQ_Customer_Email")
                    .IsUnique();

                entity.HasIndex(e => e.LastName)
                    .HasName("IDX_Customer_LastName");

                entity.HasIndex(e => new { e.LastName, e.FirstName })
                    .HasName("IDX_Custromer_FLName");

                entity.Property(e => e.DateOfBirth).HasColumnType("date");

                entity.Property(e => e.Email)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.FirstName)
                    .IsRequired()
                    .HasMaxLength(20);

                entity.Property(e => e.LastName)
                    .IsRequired()
                    .HasMaxLength(20);

                entity.Property(e => e.Phone).HasMaxLength(11);
            });

            modelBuilder.Entity<Order>(entity =>
            {
                entity.HasIndex(e => e.CustomerId)
                    .HasName("IDX_Order_CustomerId");

                entity.HasIndex(e => e.TotalPrice)
                    .HasName("IDX_Order_TotalProce");

                entity.Property(e => e.Address)
                    .IsRequired()
                    .HasMaxLength(120);

                entity.Property(e => e.Comment).HasMaxLength(300);

                entity.Property(e => e.CreatedAt)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.TotalPrice)
                    .HasColumnType("money")
                    .HasDefaultValueSql("((0))");

                entity.HasOne(d => d.Customer)
                    .WithMany(p => p.Order)
                    .HasForeignKey(d => d.CustomerId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Order_Customer");

                entity.HasOne(d => d.Status)
                    .WithMany(p => p.Order)
                    .HasForeignKey(d => d.StatusId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Order_OrderStatus");
            });

            modelBuilder.Entity<OrderProduct>(entity =>
            {
                entity.HasKey(e => new { e.OrderId, e.ProductId })
                    .HasName("PK_OrderProduct_OrderId_ProductId");

                entity.Property(e => e.Total)
                    .HasColumnType("money")
                    .HasComputedColumnSql("([CountProduct]*[UnitPrice])");

                entity.Property(e => e.UnitPrice).HasColumnType("money");

                entity.HasOne(d => d.Order)
                    .WithMany(p => p.OrderProduct)
                    .HasForeignKey(d => d.OrderId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_OrderProduct_Order");

                entity.HasOne(d => d.Product)
                    .WithMany(p => p.OrderProduct)
                    .HasForeignKey(d => d.ProductId)
                    .HasConstraintName("FK_OrderProduct_Product");
            });

            modelBuilder.Entity<OrderStatus>(entity =>
            {
                entity.HasIndex(e => e.StatusName)
                    .HasName("UQ_OrderStatus_StatusName")
                    .IsUnique();

                entity.Property(e => e.StatusName)
                    .IsRequired()
                    .HasMaxLength(40);
            });

            modelBuilder.Entity<Product>(entity =>
            {
                entity.HasIndex(e => e.Code)
                    .HasName("UQ_Product_Code")
                    .IsUnique();

                entity.Property(e => e.Code).HasDefaultValueSql("(newsequentialid())");

                entity.Property(e => e.Price).HasColumnType("money");

                entity.Property(e => e.Size).HasMaxLength(3);

                entity.Property(e => e.Title)
                    .IsRequired()
                    .HasMaxLength(30);

                entity.HasOne(d => d.Brand)
                    .WithMany(p => p.Product)
                    .HasForeignKey(d => d.BrandId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Product_Brand");

                entity.HasOne(d => d.Category)
                    .WithMany(p => p.Product)
                    .HasForeignKey(d => d.CategoryId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Product_Category");

                entity.HasOne(d => d.Color)
                    .WithMany(p => p.Product)
                    .HasForeignKey(d => d.ColorId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Product_Color");

                entity.HasOne(d => d.Team)
                    .WithMany(p => p.Product)
                    .HasForeignKey(d => d.TeamId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Product_Team");
            });

            modelBuilder.Entity<Team>(entity =>
            {
                entity.HasIndex(e => new { e.TeamName, e.TeamCity })
                    .HasName("UQ_Team_TeamName_TeamCity")
                    .IsUnique();

                entity.Property(e => e.TeamCity)
                    .IsRequired()
                    .HasMaxLength(20);

                entity.Property(e => e.TeamName)
                    .IsRequired()
                    .HasMaxLength(30);
            });
        }
    }
}
