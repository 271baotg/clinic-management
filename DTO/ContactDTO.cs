using ClinicBackend.Models;

namespace ClinicBackend.DTO
{
    public class ContactDTO
    {
        public long ContactId { get; set; }

        public string ContactType { get; set; } = null!;

        public string ContactDetail { get; set; } = null!;

    }
}
