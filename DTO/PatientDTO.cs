namespace ClinicBackend.DTO
{
    public class PatientDTO
    {
        public long PatientId { get; set; }

        public string FirstName { get; set; } = null!;

        public string LastName { get; set; } = null!;

        public sbyte? Gender { get; set; }

        public DateOnly? DateOfBirth { get; set; }

        public sbyte? Status { get; set; }

        public string? DeactiveReason { get; set; }
    }
}
