public class BloodRequirement
{
    public int RequirementId { get; set; } // Primary Key
    public required string RequiredBloodGroup { get; set; } // Required Property
    public required string PatientName { get; set; } // Required Property
    public required string Contact { get; set; } // Required Property
    public DateTime RequiredDate { get; set; }
}
