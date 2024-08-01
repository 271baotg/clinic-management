using System;
using System.Collections.Generic;

namespace ClinicBackend.Models;

public partial class Contact
{
    public long ContactId { get; set; }

    public long PatientId { get; set; }

    public string ContactType { get; set; } = null!;

    public string ContactDetail { get; set; } = null!;

    public virtual Patient Patient { get; set; } = null!;
}
