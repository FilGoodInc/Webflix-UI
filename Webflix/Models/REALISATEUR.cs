﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;

namespace Webflix.Models;

public partial class REALISATEUR
{
    public decimal IDARTISTE { get; set; }

    public virtual ICollection<FILM> FILM { get; set; } = new List<FILM>();

    public virtual ARTISTE IDARTISTENavigation { get; set; }
}