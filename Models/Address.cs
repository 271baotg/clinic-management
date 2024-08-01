using System;
using System.Collections.Generic;

namespace ClinicBackend.Models;

public partial class Address
{
    public long AddressId { get; set; }

    public long PatientId { get; set; }

    public sbyte AddressType { get; set; }

    public string? AddressLine { get; set; }

    public string? City { get; set; }

    public string? State { get; set; }

    public string? PostalCode { get; set; }

    public string? Country { get; set; }

    public virtual Patient Patient { get; set; } = null!;
}
