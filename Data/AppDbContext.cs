using Microsoft.EntityFrameworkCore;
using PaymentsSmartBankAPI.Models;

namespace PaymentsSmartBankAPI.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

        public DbSet<User> Users { get; set; }
        public DbSet<Payment> Payments { get; set; }
        public DbSet<PaymentSuggestion> PaymentSuggestions { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // Configurar la relación entre User y Payment
            modelBuilder.Entity<Payment>()
                .HasOne(p => p.User)
                .WithMany(u => u.Payments)
                .HasForeignKey(p => p.UserId);

            // Configurar la relación entre User y PaymentSuggestion
            modelBuilder.Entity<PaymentSuggestion>()
                .HasOne(ps => ps.User)
                .WithMany(u => u.PaymentSuggestions)
                .HasForeignKey(ps => ps.UserId);

            // Configurar el valor por defecto de CreatedAt en Payments y PaymentSuggestions
            modelBuilder.Entity<Payment>()
                .Property(p => p.CreatedAt)
                .HasDefaultValueSql("GETDATE()");

            modelBuilder.Entity<PaymentSuggestion>()
                .Property(ps => ps.CreatedAt)
                .HasDefaultValueSql("GETDATE()");
        }

    }
}