using Microsoft.EntityFrameworkCore;

public class BloodBankContext : DbContext
{
    public BloodBankContext(DbContextOptions<BloodBankContext> options) : base(options) { }

    public DbSet<Donor> Donors { get; set; }
    public DbSet<BloodDonation> BloodDonations { get; set; }
    public DbSet<BloodRequirement> BloodRequirements { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        // Optionally configure the primary keys if not following conventions
        modelBuilder.Entity<Donor>()
            .HasKey(d => d.DonorId);

        modelBuilder.Entity<BloodDonation>()
            .HasKey(bd => bd.DonationId);

        modelBuilder.Entity<BloodRequirement>()
            .HasKey(br => br.RequirementId);
    }
}
