﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;

namespace Webflix.Models;

public partial class GENRE
{
    public decimal IDGENRE { get; set; }

    public string NOM { get; set; }

    public virtual ICollection<GENREFILM> GENREFILM { get; set; } = new List<GENREFILM>();
}