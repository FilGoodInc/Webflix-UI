﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;

namespace Webflix.Models;

public partial class LOCATION
{
    public decimal IDLOCATION { get; set; }

    public DateTime DATEDEBUT { get; set; }

    public DateTime DATEFIN { get; set; }

    public decimal FK_IDCLIENT { get; set; }

    public decimal FK_IDEXEMPLAIRE { get; set; }

    public virtual CLIENT FK_IDCLIENTNavigation { get; set; }

    public virtual EXEMPLAIRE FK_IDEXEMPLAIRENavigation { get; set; }
}