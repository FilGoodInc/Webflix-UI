﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;

namespace Webflix.Models;

public partial class ETL_FILM
{
    public decimal IDFILM { get; set; }

    public string TITRE { get; set; }

    public decimal ANNEE { get; set; }

    public string PAYS { get; set; }

    public decimal IS_GENRE_ACTION { get; set; }

    public decimal IS_GENRE_ADVENTURE { get; set; }

    public decimal IS_GENRE_COMEDY { get; set; }

    public decimal IS_GENRE_FAMILY { get; set; }

    public decimal IS_GENRE_ROMANCE { get; set; }

    public decimal IS_GENRE_DRAMA { get; set; }

    public decimal IS_GENRE_ANIMATION { get; set; }

    public decimal IS_GENRE_FANTASY { get; set; }

    public decimal IS_GENRE_BIOGRAPHY { get; set; }

    public decimal IS_GENRE_THRILLER { get; set; }

    public decimal IS_GENRE_SCIFI { get; set; }

    public decimal IS_GENRE_CRIME { get; set; }

    public decimal IS_GENRE_SPORT { get; set; }

    public decimal IS_GENRE_HORROR { get; set; }

    public decimal IS_GENRE_FILM_NOIR { get; set; }

    public decimal IS_GENRE_MYSTERY { get; set; }

    public decimal IS_GENRE_WESTERN { get; set; }

    public decimal IS_GENRE_WAR { get; set; }

    public decimal IS_GENRE_MUSICAL { get; set; }

    public decimal IS_GENRE_DOCUMENTARY { get; set; }

    public decimal IS_GENRE_HISTORY { get; set; }

    public decimal IS_GENRE_MUSIC { get; set; }

    public virtual ICollection<ETL_LOCATION> ETL_LOCATION { get; set; } = new List<ETL_LOCATION>();
}