﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;

namespace Webflix.Models;

public partial class CLIENT
{
    public decimal IDUTILISATEUR { get; set; }

    public string FK_CODEFORFAIT { get; set; }

    public virtual ICollection<CARTECREDIT> CARTECREDIT { get; set; } = new List<CARTECREDIT>();

    public virtual FORFAIT FK_CODEFORFAITNavigation { get; set; }

    public virtual UTILISATEUR IDUTILISATEURNavigation { get; set; }

    public virtual ICollection<LOCATION> LOCATION { get; set; } = new List<LOCATION>();
}