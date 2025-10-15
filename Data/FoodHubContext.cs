using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using FoodHub.Models;

namespace FoodHub.Data
{
    public class FoodHubContext : DbContext
    {
        public FoodHubContext() : base("name=FoodHubContext")
        {
            // Enable lazy loading (optional)
            Configuration.LazyLoadingEnabled = true;
            
            // Disable proxy creation if needed
            Configuration.ProxyCreationEnabled = true;
            
            // Enable database creation if it doesn't exist
            Database.SetInitializer<FoodHubContext>(new CreateDatabaseIfNotExists<FoodHubContext>());
        }

        // DbSets for all entities
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<OrderItem> OrderItems { get; set; }
        public DbSet<FoodItem> FoodItems { get; set; }
        public DbSet<Ingredient> Ingredients { get; set; }
        public DbSet<FoodItemIngredient> FoodItemIngredients { get; set; }
        public DbSet<Rider> Riders { get; set; }
        public DbSet<Dependent> Dependents { get; set; }
        public DbSet<MotorBike> MotorBikes { get; set; }
        public DbSet<BikeColor> BikeColors { get; set; }
        public DbSet<BikeAssignment> BikeAssignments { get; set; }
        public DbSet<Delivery> Deliveries { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            // Remove pluralizing table name convention
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();

            // Configure composite primary keys
            modelBuilder.Entity<OrderItem>()
                .HasKey(oi => new { oi.OrderID, oi.ItemID });

            modelBuilder.Entity<FoodItemIngredient>()
                .HasKey(fii => new { fii.ItemID, fii.IngredientID });

            modelBuilder.Entity<BikeColor>()
                .HasKey(bc => new { bc.BikeRegNo, bc.Color });

            // Configure relationships
            
            // Customer -> Orders (One-to-Many)
            modelBuilder.Entity<Order>()
                .HasRequired(o => o.Customer)
                .WithMany(c => c.Orders)
                .HasForeignKey(o => o.CustomerID)
                .WillCascadeOnDelete(false);

            // Order -> OrderItems (One-to-Many)
            modelBuilder.Entity<OrderItem>()
                .HasRequired(oi => oi.Order)
                .WithMany(o => o.OrderItems)
                .HasForeignKey(oi => oi.OrderID)
                .WillCascadeOnDelete(true);

            // FoodItem -> OrderItems (One-to-Many)
            modelBuilder.Entity<OrderItem>()
                .HasRequired(oi => oi.FoodItem)
                .WithMany(fi => fi.OrderItems)
                .HasForeignKey(oi => oi.ItemID)
                .WillCascadeOnDelete(false);

            // FoodItem -> FoodItemIngredients (One-to-Many)
            modelBuilder.Entity<FoodItemIngredient>()
                .HasRequired(fii => fii.FoodItem)
                .WithMany(fi => fi.FoodItemIngredients)
                .HasForeignKey(fii => fii.ItemID)
                .WillCascadeOnDelete(true);

            // Ingredient -> FoodItemIngredients (One-to-Many)
            modelBuilder.Entity<FoodItemIngredient>()
                .HasRequired(fii => fii.Ingredient)
                .WithMany(i => i.FoodItemIngredients)
                .HasForeignKey(fii => fii.IngredientID)
                .WillCascadeOnDelete(true);

            // Rider -> Dependents (One-to-Many)
            modelBuilder.Entity<Dependent>()
                .HasRequired(d => d.Rider)
                .WithMany(r => r.Dependents)
                .HasForeignKey(d => d.RiderID)
                .WillCascadeOnDelete(true);

            // Rider -> BikeAssignments (One-to-Many)
            modelBuilder.Entity<BikeAssignment>()
                .HasRequired(ba => ba.Rider)
                .WithMany(r => r.BikeAssignments)
                .HasForeignKey(ba => ba.RiderID)
                .WillCascadeOnDelete(false);

            // MotorBike -> BikeAssignments (One-to-Many)
            modelBuilder.Entity<BikeAssignment>()
                .HasRequired(ba => ba.MotorBike)
                .WithMany(mb => mb.BikeAssignments)
                .HasForeignKey(ba => ba.BikeRegNo)
                .WillCascadeOnDelete(false);

            // MotorBike -> BikeColors (One-to-Many)
            modelBuilder.Entity<BikeColor>()
                .HasRequired(bc => bc.MotorBike)
                .WithMany(mb => mb.BikeColors)
                .HasForeignKey(bc => bc.BikeRegNo)
                .WillCascadeOnDelete(true);

            // Order -> Deliveries (One-to-Many)
            modelBuilder.Entity<Delivery>()
                .HasRequired(d => d.Order)
                .WithMany(o => o.Deliveries)
                .HasForeignKey(d => d.OrderID)
                .WillCascadeOnDelete(false);

            // Rider -> Deliveries (One-to-Many)
            modelBuilder.Entity<Delivery>()
                .HasRequired(d => d.Rider)
                .WithMany(r => r.Deliveries)
                .HasForeignKey(d => d.RiderID)
                .WillCascadeOnDelete(false);

            // MotorBike -> Deliveries (Optional One-to-Many)
            modelBuilder.Entity<Delivery>()
                .HasOptional(d => d.MotorBike)
                .WithMany(mb => mb.Deliveries)
                .HasForeignKey(d => d.BikeRegNo);

            // Configure string lengths and column types
            modelBuilder.Entity<Customer>()
                .Property(c => c.Name)
                .HasMaxLength(100)
                .IsRequired();

            modelBuilder.Entity<Customer>()
                .Property(c => c.NIC)
                .HasMaxLength(12)
                .IsRequired();

            modelBuilder.Entity<FoodItem>()
                .Property(fi => fi.Price)
                .HasPrecision(18, 2);

            modelBuilder.Entity<Order>()
                .Property(o => o.OrderAmount)
                .HasPrecision(18, 2);

            base.OnModelCreating(modelBuilder);
        }
    }
}
