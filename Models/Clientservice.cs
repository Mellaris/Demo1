﻿using System;
using System.Collections.Generic;

namespace AvaloniaApplication2.Models;

public partial class Clientservice
{
    public int Id { get; set; }

    public int Clientid { get; set; }

    public int Serviceid { get; set; }

    public string Starttime { get; set; } = null!;

    public string? Comment { get; set; }

    public virtual Client Client { get; set; } = null!;

    public virtual ICollection<Documentbyservice> Documentbyservices { get; set; } = new List<Documentbyservice>();

    public virtual ICollection<Productsale> Productsales { get; set; } = new List<Productsale>();

    public virtual Service Service { get; set; } = null!;
}
