using System;
using System.Collections.Generic;

namespace BusinessLogic.Models;

public partial class Client
{
    public int Id { get; set; }

    public string Clientname { get; set; } = null!;

    public string? Email { get; set; }

    public decimal Phonenumber { get; set; }

    public DateTime? Admindate { get; set; }
}
