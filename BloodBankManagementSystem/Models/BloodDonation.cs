public class BloodDonation
{
    public int DonationId { get; set; } // Primary Key
    public required string BloodGroup { get; set; } // Required Property
    public DateTime DateOfDonation { get; set; }
    public required string StorageLocation { get; set; } // Required Property
}
