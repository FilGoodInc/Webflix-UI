﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;

namespace Webflix.Models;

public partial class ETL_CLIENT
{
    public decimal IDUTILISATEUR { get; set; }

    public string NOM { get; set; }

    public string GROUPE_D_AGE { get; set; }

    public string ANCIENNETE { get; set; }

    public string CODE_POSTAL { get; set; }

    public string VILLE { get; set; }

    public string PROVINCE { get; set; }

    public virtual ICollection<ETL_LOCATION> ETL_LOCATION { get; set; } = new List<ETL_LOCATION>();
}