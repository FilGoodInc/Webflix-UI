﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;

namespace Webflix.Models;

public partial class ETL_TEMPS
{
    public decimal IDTEMPS { get; set; }

    public DateTime CAL_DATE { get; set; }

    public decimal HEURE { get; set; }

    public string JOUR_DE_LA_SEMAINE { get; set; }

    public string MOIS { get; set; }

    public decimal CAL_ANNEE { get; set; }

    public virtual ICollection<ETL_LOCATION> ETL_LOCATION { get; set; } = new List<ETL_LOCATION>();
}