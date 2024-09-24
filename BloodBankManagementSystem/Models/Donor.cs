public class Donor
{
    public int DonorId { get; set; } // Primary Key
    public required string Name { get; set; } // Required Property
    public string? BloodGroup { get; set; } // Nullable Property
    public string? Contact { get; set; } // Nullable Property
    public DateTime LastDonationDate { get; set; }
}
