using System;
using System.Collections.Generic;

namespace ClinicBackend.Models;

public partial class Patient
{
    public long? PatientId { get; set; }

    public string FirstName { get; set; } = null!;

    public string LastName { get; set; } = null!;

    public sbyte? Gender { get; set; }

    public DateOnly? DateOfBirth { get; set; }

    public sbyte? Status { get; set; }

    public string? DeactiveReason { get; set; }

    public virtual ICollection<Address> Addresses { get; set; } = new List<Address>();

    public virtual ICollection<Contact> Contacts { get; set; } = new List<Contact>();
}
