﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace Webflix.Models;

public partial class DbWebflix : DbContext
{
    public virtual DbSet<ACTEUR> ACTEUR { get; set; }

    public virtual DbSet<ACTEURFILM> ACTEURFILM { get; set; }

    public virtual DbSet<ADRESSE> ADRESSE { get; set; }

    public virtual DbSet<ARTISTE> ARTISTE { get; set; }

    public virtual DbSet<CARTECREDIT> CARTECREDIT { get; set; }

    public virtual DbSet<CLIENT> CLIENT { get; set; }

    public virtual DbSet<EMPLOYE> EMPLOYE { get; set; }

    public virtual DbSet<ETL_CLIENT> ETL_CLIENT { get; set; }

    public virtual DbSet<ETL_FILM> ETL_FILM { get; set; }

    public virtual DbSet<ETL_LOCATION> ETL_LOCATION { get; set; }

    public virtual DbSet<ETL_TEMPS> ETL_TEMPS { get; set; }

    public virtual DbSet<EXEMPLAIRE> EXEMPLAIRE { get; set; }

    public virtual DbSet<FILM> FILM { get; set; }

    public virtual DbSet<FORFAIT> FORFAIT { get; set; }

    public virtual DbSet<GENRE> GENRE { get; set; }

    public virtual DbSet<GENREFILM> GENREFILM { get; set; }

    public virtual DbSet<LOCATION> LOCATION { get; set; }

    public virtual DbSet<PERSONNAGE> PERSONNAGE { get; set; }

    public virtual DbSet<REALISATEUR> REALISATEUR { get; set; }

    public virtual DbSet<SCENARISTE> SCENARISTE { get; set; }

    public virtual DbSet<SCENARISTEFILM> SCENARISTEFILM { get; set; }

    public virtual DbSet<UTILISATEUR> UTILISATEUR { get; set; }

    public virtual DbSet<VUE_MAT_CORRELATION> VUE_MAT_CORRELATION { get; set; }

    public virtual DbSet<VUE_MAT_MOYENNE_COTE> VUE_MAT_MOYENNE_COTE { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        => optionsBuilder.UseOracle("DATA SOURCE=log660ora12c.logti.etsmtl.ca:1521/log660ora12c.logti.etsmtl.ca;PASSWORD=HCYrEv9a;USER ID=EQUIPE113");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder
            .HasDefaultSchema("EQUIPE113")
            .UseCollation("USING_NLS_COMP");

        modelBuilder.Entity<ACTEUR>(entity =>
        {
            entity.HasKey(e => e.IDARTISTE).HasName("SYS_C002429887");

            entity.Property(e => e.IDARTISTE).HasColumnType("NUMBER(38)");

            entity.HasOne(d => d.IDARTISTENavigation).WithOne(p => p.ACTEUR)
                .HasForeignKey<ACTEUR>(d => d.IDARTISTE)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("SYS_C002429888");
        });

        modelBuilder.Entity<ACTEURFILM>(entity =>
        {
            entity.HasKey(e => new { e.FK_IDFILM, e.FK_IDACTEUR }).HasName("SYS_C002429959");

            entity.Property(e => e.FK_IDFILM).HasColumnType("NUMBER(38)");
            entity.Property(e => e.FK_IDACTEUR).HasColumnType("NUMBER(38)");

            entity.HasOne(d => d.FK_IDACTEURNavigation).WithMany(p => p.ACTEURFILM)
                .HasForeignKey(d => d.FK_IDACTEUR)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("SYS_C002429961");

            entity.HasOne(d => d.FK_IDFILMNavigation).WithMany(p => p.ACTEURFILM)
                .HasForeignKey(d => d.FK_IDFILM)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("SYS_C002429960");
        });

        modelBuilder.Entity<ADRESSE>(entity =>
        {
            entity.HasKey(e => e.IDADRESSE).HasName("SYS_C002429945");

            entity.Property(e => e.IDADRESSE).HasColumnType("NUMBER(38)");
            entity.Property(e => e.CODEPOSTAL)
                .IsRequired()
                .HasMaxLength(6)
                .IsUnicode(false);
            entity.Property(e => e.FK_IDUTILISATEUR).HasColumnType("NUMBER(38)");
            entity.Property(e => e.LIGNEADRESSE)
                .IsRequired()
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.PROVINCE)
                .IsRequired()
                .HasMaxLength(30)
                .IsUnicode(false);
            entity.Property(e => e.VILLE)
                .IsRequired()
                .HasMaxLength(90)
                .IsUnicode(false);

            entity.HasOne(d => d.FK_IDUTILISATEURNavigation).WithMany(p => p.ADRESSE)
                .HasForeignKey(d => d.FK_IDUTILISATEUR)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("SYS_C002429946");
        });

        modelBuilder.Entity<ARTISTE>(entity =>
        {
            entity.HasKey(e => e.IDARTISTE).HasName("SYS_C002429886");

            entity.Property(e => e.IDARTISTE).HasColumnType("NUMBER(38)");
            entity.Property(e => e.BIOGRAPHIE)
                .HasMaxLength(3000)
                .IsUnicode(false);
            entity.Property(e => e.DATENAISSANCE).HasColumnType("DATE");
            entity.Property(e => e.LIEUNAISSANCE)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.NOM)
                .IsRequired()
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.PHOTO)
                .HasMaxLength(500)
                .IsUnicode(false);
        });

        modelBuilder.Entity<CARTECREDIT>(entity =>
        {
            entity.HasKey(e => e.NUMCARTE).HasName("SYS_C002429938");

            entity.Property(e => e.NUMCARTE)
                .HasMaxLength(16)
                .IsUnicode(false);
            entity.Property(e => e.CVV).HasColumnType("NUMBER(38)");
            entity.Property(e => e.DATEEXPIRATION).HasColumnType("DATE");
            entity.Property(e => e.FK_IDCLIENT).HasColumnType("NUMBER(38)");
            entity.Property(e => e.TYPECARTE)
                .IsRequired()
                .HasMaxLength(10)
                .IsUnicode(false);

            entity.HasOne(d => d.FK_IDCLIENTNavigation).WithMany(p => p.CARTECREDIT)
                .HasForeignKey(d => d.FK_IDCLIENT)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("SYS_C002429939");
        });

        modelBuilder.Entity<CLIENT>(entity =>
        {
            entity.HasKey(e => e.IDUTILISATEUR).HasName("SYS_C002429917");

            entity.Property(e => e.IDUTILISATEUR).HasColumnType("NUMBER(38)");
            entity.Property(e => e.FK_CODEFORFAIT)
                .IsRequired()
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength();

            entity.HasOne(d => d.FK_CODEFORFAITNavigation).WithMany(p => p.CLIENT)
                .HasForeignKey(d => d.FK_CODEFORFAIT)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("SYS_C002429919");

            entity.HasOne(d => d.IDUTILISATEURNavigation).WithOne(p => p.CLIENT)
                .HasForeignKey<CLIENT>(d => d.IDUTILISATEUR)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("SYS_C002429918");
        });

        modelBuilder.Entity<EMPLOYE>(entity =>
        {
            entity.HasKey(e => e.IDUTILISATEUR).HasName("SYS_C002429921");

            entity.Property(e => e.IDUTILISATEUR).HasColumnType("NUMBER(38)");
            entity.Property(e => e.MATRICULE).HasColumnType("NUMBER(38)");

            entity.HasOne(d => d.IDUTILISATEURNavigation).WithOne(p => p.EMPLOYE)
                .HasForeignKey<EMPLOYE>(d => d.IDUTILISATEUR)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("SYS_C002429922");
        });

        modelBuilder.Entity<ETL_CLIENT>(entity =>
        {
            entity.HasKey(e => e.IDUTILISATEUR).HasName("SYS_C002445215");

            entity.Property(e => e.IDUTILISATEUR).HasColumnType("NUMBER(38)");
            entity.Property(e => e.ANCIENNETE)
                .IsRequired()
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.CODE_POSTAL)
                .IsRequired()
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.GROUPE_D_AGE)
                .IsRequired()
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.NOM)
                .IsRequired()
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.PROVINCE)
                .IsRequired()
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.VILLE)
                .IsRequired()
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        modelBuilder.Entity<ETL_FILM>(entity =>
        {
            entity.HasKey(e => e.IDFILM).HasName("SYS_C002444787");

            entity.Property(e => e.IDFILM).HasColumnType("NUMBER(38)");
            entity.Property(e => e.ANNEE).HasColumnType("NUMBER(38)");
            entity.Property(e => e.IS_GENRE_ACTION).HasColumnType("NUMBER(38)");
            entity.Property(e => e.IS_GENRE_ADVENTURE).HasColumnType("NUMBER(38)");
            entity.Property(e => e.IS_GENRE_ANIMATION).HasColumnType("NUMBER(38)");
            entity.Property(e => e.IS_GENRE_BIOGRAPHY).HasColumnType("NUMBER(38)");
            entity.Property(e => e.IS_GENRE_COMEDY).HasColumnType("NUMBER(38)");
            entity.Property(e => e.IS_GENRE_CRIME).HasColumnType("NUMBER(38)");
            entity.Property(e => e.IS_GENRE_DOCUMENTARY).HasColumnType("NUMBER(38)");
            entity.Property(e => e.IS_GENRE_DRAMA).HasColumnType("NUMBER(38)");
            entity.Property(e => e.IS_GENRE_FAMILY).HasColumnType("NUMBER(38)");
            entity.Property(e => e.IS_GENRE_FANTASY).HasColumnType("NUMBER(38)");
            entity.Property(e => e.IS_GENRE_FILM_NOIR).HasColumnType("NUMBER(38)");
            entity.Property(e => e.IS_GENRE_HISTORY).HasColumnType("NUMBER(38)");
            entity.Property(e => e.IS_GENRE_HORROR).HasColumnType("NUMBER(38)");
            entity.Property(e => e.IS_GENRE_MUSIC).HasColumnType("NUMBER(38)");
            entity.Property(e => e.IS_GENRE_MUSICAL).HasColumnType("NUMBER(38)");
            entity.Property(e => e.IS_GENRE_MYSTERY).HasColumnType("NUMBER(38)");
            entity.Property(e => e.IS_GENRE_ROMANCE).HasColumnType("NUMBER(38)");
            entity.Property(e => e.IS_GENRE_SCIFI).HasColumnType("NUMBER(38)");
            entity.Property(e => e.IS_GENRE_SPORT).HasColumnType("NUMBER(38)");
            entity.Property(e => e.IS_GENRE_THRILLER).HasColumnType("NUMBER(38)");
            entity.Property(e => e.IS_GENRE_WAR).HasColumnType("NUMBER(38)");
            entity.Property(e => e.IS_GENRE_WESTERN).HasColumnType("NUMBER(38)");
            entity.Property(e => e.PAYS)
                .IsRequired()
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.TITRE)
                .IsRequired()
                .HasMaxLength(200)
                .IsUnicode(false);
        });

        modelBuilder.Entity<ETL_LOCATION>(entity =>
        {
            entity.HasKey(e => e.ID_ETL_LOCATION).HasName("SYS_C002445219");

            entity.Property(e => e.ID_ETL_LOCATION).HasColumnType("NUMBER(38)");
            entity.Property(e => e.IDFILM).HasColumnType("NUMBER(38)");
            entity.Property(e => e.IDTEMPS).HasColumnType("NUMBER(38)");
            entity.Property(e => e.IDUTILISATEUR).HasColumnType("NUMBER(38)");

            entity.HasOne(d => d.IDFILMNavigation).WithMany(p => p.ETL_LOCATION)
                .HasForeignKey(d => d.IDFILM)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("SYS_C002445221");

            entity.HasOne(d => d.IDTEMPSNavigation).WithMany(p => p.ETL_LOCATION)
                .HasForeignKey(d => d.IDTEMPS)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("SYS_C002445222");

            entity.HasOne(d => d.IDUTILISATEURNavigation).WithMany(p => p.ETL_LOCATION)
                .HasForeignKey(d => d.IDUTILISATEUR)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("SYS_C002445220");
        });

        modelBuilder.Entity<ETL_TEMPS>(entity =>
        {
            entity.HasKey(e => e.IDTEMPS).HasName("SYS_C002444738");

            entity.Property(e => e.IDTEMPS).HasColumnType("NUMBER(38)");
            entity.Property(e => e.CAL_ANNEE).HasColumnType("NUMBER(38)");
            entity.Property(e => e.CAL_DATE).HasColumnType("DATE");
            entity.Property(e => e.HEURE).HasColumnType("NUMBER(38)");
            entity.Property(e => e.JOUR_DE_LA_SEMAINE)
                .IsRequired()
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.MOIS)
                .IsRequired()
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        modelBuilder.Entity<EXEMPLAIRE>(entity =>
        {
            entity.HasKey(e => e.IDEXEMPLAIRE).HasName("SYS_C002429924");

            entity.Property(e => e.IDEXEMPLAIRE).HasColumnType("NUMBER(38)");
            entity.Property(e => e.FK_IDFILM).HasColumnType("NUMBER(38)");
            entity.Property(e => e.LOUE)
                .IsRequired()
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasDefaultValueSql("0 ")
                .IsFixedLength();

            entity.HasOne(d => d.FK_IDFILMNavigation).WithMany(p => p.EXEMPLAIRE)
                .HasForeignKey(d => d.FK_IDFILM)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("SYS_C002429925");
        });

        modelBuilder.Entity<FILM>(entity =>
        {
            entity.HasKey(e => e.IDFILM).HasName("SYS_C002429897");

            entity.Property(e => e.IDFILM).HasColumnType("NUMBER(38)");
            entity.Property(e => e.AFFICHE)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.ANNEE).HasColumnType("NUMBER(38)");
            entity.Property(e => e.DUREE).HasColumnType("NUMBER(38)");
            entity.Property(e => e.FK_IDREALISATEUR).HasColumnType("NUMBER(38)");
            entity.Property(e => e.LANGUEORIGINALE)
                .HasMaxLength(30)
                .IsUnicode(false);
            entity.Property(e => e.LIENSBANDEANNONCE)
                .HasMaxLength(3000)
                .IsUnicode(false);
            entity.Property(e => e.PAYS)
                .IsRequired()
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.RESUME)
                .HasMaxLength(500)
                .IsUnicode(false);
            entity.Property(e => e.TITRE)
                .IsRequired()
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.HasOne(d => d.FK_IDREALISATEURNavigation).WithMany(p => p.FILM)
                .HasForeignKey(d => d.FK_IDREALISATEUR)
                .HasConstraintName("SYS_C002429898");
        });

        modelBuilder.Entity<FORFAIT>(entity =>
        {
            entity.HasKey(e => e.CODEFORFAIT).HasName("SYS_C002429908");

            entity.Property(e => e.CODEFORFAIT)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.COUT).HasColumnType("NUMBER(38)");
            entity.Property(e => e.DUREEMAX).HasColumnType("NUMBER(38)");
            entity.Property(e => e.NBLOCATIONMAX).HasColumnType("NUMBER(38)");
            entity.Property(e => e.NOM)
                .IsRequired()
                .HasMaxLength(13)
                .IsUnicode(false);
        });

        modelBuilder.Entity<GENRE>(entity =>
        {
            entity.HasKey(e => e.IDGENRE).HasName("SYS_C002429884");

            entity.Property(e => e.IDGENRE).HasColumnType("NUMBER(38)");
            entity.Property(e => e.NOM)
                .IsRequired()
                .HasMaxLength(30)
                .IsUnicode(false);
        });

        modelBuilder.Entity<GENREFILM>(entity =>
        {
            entity.HasKey(e => new { e.FK_IDFILM, e.FK_IDGENRE }).HasName("SYS_C002429949");

            entity.Property(e => e.FK_IDFILM).HasColumnType("NUMBER(38)");
            entity.Property(e => e.FK_IDGENRE).HasColumnType("NUMBER(38)");

            entity.HasOne(d => d.FK_IDFILMNavigation).WithMany(p => p.GENREFILM)
                .HasForeignKey(d => d.FK_IDFILM)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("SYS_C002429950");

            entity.HasOne(d => d.FK_IDGENRENavigation).WithMany(p => p.GENREFILM)
                .HasForeignKey(d => d.FK_IDGENRE)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("SYS_C002429951");
        });

        modelBuilder.Entity<LOCATION>(entity =>
        {
            entity.HasKey(e => e.IDLOCATION).HasName("SYS_C002429930");

            entity.Property(e => e.IDLOCATION).HasColumnType("NUMBER(38)");
            entity.Property(e => e.DATEDEBUT).HasColumnType("DATE");
            entity.Property(e => e.DATEFIN).HasColumnType("DATE");
            entity.Property(e => e.FK_IDCLIENT).HasColumnType("NUMBER(38)");
            entity.Property(e => e.FK_IDEXEMPLAIRE).HasColumnType("NUMBER(38)");

            entity.HasOne(d => d.FK_IDCLIENTNavigation).WithMany(p => p.LOCATION)
                .HasForeignKey(d => d.FK_IDCLIENT)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("SYS_C002429931");

            entity.HasOne(d => d.FK_IDEXEMPLAIRENavigation).WithMany(p => p.LOCATION)
                .HasForeignKey(d => d.FK_IDEXEMPLAIRE)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("SYS_C002429932");
        });

        modelBuilder.Entity<PERSONNAGE>(entity =>
        {
            entity.HasKey(e => e.IDPERSONNAGE).HasName("SYS_C002429902");

            entity.Property(e => e.IDPERSONNAGE).HasColumnType("NUMBER(38)");
            entity.Property(e => e.FK_IDACTEUR).HasColumnType("NUMBER(38)");
            entity.Property(e => e.FK_IDFILM).HasColumnType("NUMBER(38)");
            entity.Property(e => e.NOM)
                .IsRequired()
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.HasOne(d => d.FK_IDACTEURNavigation).WithMany(p => p.PERSONNAGE)
                .HasForeignKey(d => d.FK_IDACTEUR)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("SYS_C002429904");

            entity.HasOne(d => d.FK_IDFILMNavigation).WithMany(p => p.PERSONNAGE)
                .HasForeignKey(d => d.FK_IDFILM)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("SYS_C002429903");
        });

        modelBuilder.Entity<REALISATEUR>(entity =>
        {
            entity.HasKey(e => e.IDARTISTE).HasName("SYS_C002429889");

            entity.Property(e => e.IDARTISTE).HasColumnType("NUMBER(38)");

            entity.HasOne(d => d.IDARTISTENavigation).WithOne(p => p.REALISATEUR)
                .HasForeignKey<REALISATEUR>(d => d.IDARTISTE)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("SYS_C002429890");
        });

        modelBuilder.Entity<SCENARISTE>(entity =>
        {
            entity.HasKey(e => e.IDSCENARISTE).HasName("SYS_C002429892");

            entity.Property(e => e.IDSCENARISTE).HasColumnType("NUMBER(38)");
            entity.Property(e => e.NOM)
                .IsRequired()
                .HasMaxLength(100)
                .IsUnicode(false);
        });

        modelBuilder.Entity<SCENARISTEFILM>(entity =>
        {
            entity.HasKey(e => new { e.FK_IDFILM, e.FK_IDSCENARISTE }).HasName("SYS_C002429954");

            entity.Property(e => e.FK_IDFILM).HasColumnType("NUMBER(38)");
            entity.Property(e => e.FK_IDSCENARISTE).HasColumnType("NUMBER(38)");

            entity.HasOne(d => d.FK_IDFILMNavigation).WithMany(p => p.SCENARISTEFILM)
                .HasForeignKey(d => d.FK_IDFILM)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("SYS_C002429955");

            entity.HasOne(d => d.FK_IDSCENARISTENavigation).WithMany(p => p.SCENARISTEFILM)
                .HasForeignKey(d => d.FK_IDSCENARISTE)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("SYS_C002429956");
        });

        modelBuilder.Entity<UTILISATEUR>(entity =>
        {
            entity.HasKey(e => e.IDUTILISATEUR).HasName("SYS_C002429915");

            entity.Property(e => e.IDUTILISATEUR).HasColumnType("NUMBER(38)");
            entity.Property(e => e.ADRESSECOURRIEL)
                .IsRequired()
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.DATENAISSANCE).HasColumnType("DATE");
            entity.Property(e => e.MOTDEPASSE)
                .IsRequired()
                .HasMaxLength(30)
                .IsUnicode(false);
            entity.Property(e => e.NOM)
                .IsRequired()
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.NOTELEPHONE)
                .IsRequired()
                .HasMaxLength(15)
                .IsUnicode(false);
        });

        modelBuilder.Entity<VUE_MAT_CORRELATION>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("VUE_MAT_CORRELATION");

            entity.Property(e => e.CORRELATION).HasColumnType("NUMBER");
            entity.Property(e => e.FILMID1).HasColumnType("NUMBER(38)");
            entity.Property(e => e.FILMID2).HasColumnType("NUMBER(38)");
        });

        modelBuilder.Entity<VUE_MAT_MOYENNE_COTE>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("VUE_MAT_MOYENNE_COTE");

            entity.Property(e => e.AVG_COTE).HasColumnType("NUMBER");
            entity.Property(e => e.IDFILM).HasColumnType("NUMBER(38)");
        });
        modelBuilder.HasSequence("ADRESSE_SEQUENCE");
        modelBuilder.HasSequence("LOCATION_SEQUENCE");
        modelBuilder.HasSequence("UTILISATEUR_SEQUENCE");

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}