﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;

namespace Webflix.Models;

public partial class ARTISTE
{
    public decimal IDARTISTE { get; set; }

    public string NOM { get; set; }

    public DateTime? DATENAISSANCE { get; set; }

    public string LIEUNAISSANCE { get; set; }

    public string PHOTO { get; set; }

    public string BIOGRAPHIE { get; set; }

    public virtual ACTEUR ACTEUR { get; set; }

    public virtual REALISATEUR REALISATEUR { get; set; }
}