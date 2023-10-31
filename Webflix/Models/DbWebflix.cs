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

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        => optionsBuilder.UseOracle("DATA SOURCE=log660ora12c.logti.etsmtl.ca:1521/log660ora12c.logti.etsmtl.ca;PASSWORD=HCYrEv9a;USER ID=EQUIPE113");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder
            .HasDefaultSchema("EQUIPE113")
            .UseCollation("USING_NLS_COMP");

        modelBuilder.Entity<ACTEUR>(entity =>
        {
            entity.HasKey(e => e.IDARTISTE).HasName("SYS_C002405750");

            entity.Property(e => e.IDARTISTE).HasColumnType("NUMBER(38)");

            entity.HasOne(d => d.IDARTISTENavigation).WithOne(p => p.ACTEUR)
                .HasForeignKey<ACTEUR>(d => d.IDARTISTE)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("SYS_C002405751");
        });

        modelBuilder.Entity<ACTEURFILM>(entity =>
        {
            entity.HasKey(e => new { e.FK_IDFILM, e.FK_IDACTEUR }).HasName("SYS_C002405822");

            entity.Property(e => e.FK_IDFILM).HasColumnType("NUMBER(38)");
            entity.Property(e => e.FK_IDACTEUR).HasColumnType("NUMBER(38)");

            entity.HasOne(d => d.FK_IDACTEURNavigation).WithMany(p => p.ACTEURFILM)
                .HasForeignKey(d => d.FK_IDACTEUR)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("SYS_C002405824");

            entity.HasOne(d => d.FK_IDFILMNavigation).WithMany(p => p.ACTEURFILM)
                .HasForeignKey(d => d.FK_IDFILM)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("SYS_C002405823");
        });

        modelBuilder.Entity<ADRESSE>(entity =>
        {
            entity.HasKey(e => e.IDADRESSE).HasName("SYS_C002405808");

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
                .HasConstraintName("SYS_C002405809");
        });

        modelBuilder.Entity<ARTISTE>(entity =>
        {
            entity.HasKey(e => e.IDARTISTE).HasName("SYS_C002405749");

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
            entity.HasKey(e => e.NUMCARTE).HasName("SYS_C002405801");

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
                .HasConstraintName("SYS_C002405802");
        });

        modelBuilder.Entity<CLIENT>(entity =>
        {
            entity.HasKey(e => e.IDUTILISATEUR).HasName("SYS_C002405780");

            entity.Property(e => e.IDUTILISATEUR).HasColumnType("NUMBER(38)");
            entity.Property(e => e.FK_CODEFORFAIT)
                .IsRequired()
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength();

            entity.HasOne(d => d.FK_CODEFORFAITNavigation).WithMany(p => p.CLIENT)
                .HasForeignKey(d => d.FK_CODEFORFAIT)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("SYS_C002405782");

            entity.HasOne(d => d.IDUTILISATEURNavigation).WithOne(p => p.CLIENT)
                .HasForeignKey<CLIENT>(d => d.IDUTILISATEUR)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("SYS_C002405781");
        });

        modelBuilder.Entity<EMPLOYE>(entity =>
        {
            entity.HasKey(e => e.IDUTILISATEUR).HasName("SYS_C002405784");

            entity.Property(e => e.IDUTILISATEUR).HasColumnType("NUMBER(38)");
            entity.Property(e => e.MATRICULE).HasColumnType("NUMBER(38)");

            entity.HasOne(d => d.IDUTILISATEURNavigation).WithOne(p => p.EMPLOYE)
                .HasForeignKey<EMPLOYE>(d => d.IDUTILISATEUR)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("SYS_C002405785");
        });

        modelBuilder.Entity<EXEMPLAIRE>(entity =>
        {
            entity.HasKey(e => e.IDEXEMPLAIRE).HasName("SYS_C002405787");

            entity.Property(e => e.IDEXEMPLAIRE).HasColumnType("NUMBER(38)");
            entity.Property(e => e.FK_IDFILM).HasColumnType("NUMBER(38)");

            entity.HasOne(d => d.FK_IDFILMNavigation).WithMany(p => p.EXEMPLAIRE)
                .HasForeignKey(d => d.FK_IDFILM)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("SYS_C002405788");
        });

        modelBuilder.Entity<FILM>(entity =>
        {
            entity.HasKey(e => e.IDFILM).HasName("SYS_C002405760");

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
                .HasConstraintName("SYS_C002405761");
        });

        modelBuilder.Entity<FORFAIT>(entity =>
        {
            entity.HasKey(e => e.CODEFORFAIT).HasName("SYS_C002405771");

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
            entity.HasKey(e => e.IDGENRE).HasName("SYS_C002405747");

            entity.Property(e => e.IDGENRE).HasColumnType("NUMBER(38)");
            entity.Property(e => e.NOM)
                .IsRequired()
                .HasMaxLength(30)
                .IsUnicode(false);
        });

        modelBuilder.Entity<GENREFILM>(entity =>
        {
            entity.HasKey(e => new { e.FK_IDFILM, e.FK_IDGENRE }).HasName("SYS_C002405812");

            entity.Property(e => e.FK_IDFILM).HasColumnType("NUMBER(38)");
            entity.Property(e => e.FK_IDGENRE).HasColumnType("NUMBER(38)");

            entity.HasOne(d => d.FK_IDFILMNavigation).WithMany(p => p.GENREFILM)
                .HasForeignKey(d => d.FK_IDFILM)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("SYS_C002405813");

            entity.HasOne(d => d.FK_IDGENRENavigation).WithMany(p => p.GENREFILM)
                .HasForeignKey(d => d.FK_IDGENRE)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("SYS_C002405814");
        });

        modelBuilder.Entity<LOCATION>(entity =>
        {
            entity.HasKey(e => e.IDLOCATION).HasName("SYS_C002405793");

            entity.Property(e => e.IDLOCATION).HasColumnType("NUMBER(38)");
            entity.Property(e => e.DATEDEBUT).HasColumnType("DATE");
            entity.Property(e => e.DATEFIN).HasColumnType("DATE");
            entity.Property(e => e.FK_IDCLIENT).HasColumnType("NUMBER(38)");
            entity.Property(e => e.FK_IDEXEMPLAIRE).HasColumnType("NUMBER(38)");

            entity.HasOne(d => d.FK_IDCLIENTNavigation).WithMany(p => p.LOCATION)
                .HasForeignKey(d => d.FK_IDCLIENT)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("SYS_C002405794");

            entity.HasOne(d => d.FK_IDEXEMPLAIRENavigation).WithMany(p => p.LOCATION)
                .HasForeignKey(d => d.FK_IDEXEMPLAIRE)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("SYS_C002405795");
        });

        modelBuilder.Entity<PERSONNAGE>(entity =>
        {
            entity.HasKey(e => e.IDPERSONNAGE).HasName("SYS_C002405765");

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
                .HasConstraintName("SYS_C002405767");

            entity.HasOne(d => d.FK_IDFILMNavigation).WithMany(p => p.PERSONNAGE)
                .HasForeignKey(d => d.FK_IDFILM)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("SYS_C002405766");
        });

        modelBuilder.Entity<REALISATEUR>(entity =>
        {
            entity.HasKey(e => e.IDARTISTE).HasName("SYS_C002405752");

            entity.Property(e => e.IDARTISTE).HasColumnType("NUMBER(38)");

            entity.HasOne(d => d.IDARTISTENavigation).WithOne(p => p.REALISATEUR)
                .HasForeignKey<REALISATEUR>(d => d.IDARTISTE)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("SYS_C002405753");
        });

        modelBuilder.Entity<SCENARISTE>(entity =>
        {
            entity.HasKey(e => e.IDSCENARISTE).HasName("SYS_C002405755");

            entity.Property(e => e.IDSCENARISTE).HasColumnType("NUMBER(38)");
            entity.Property(e => e.NOM)
                .IsRequired()
                .HasMaxLength(100)
                .IsUnicode(false);
        });

        modelBuilder.Entity<SCENARISTEFILM>(entity =>
        {
            entity.HasKey(e => new { e.FK_IDFILM, e.FK_IDSCENARISTE }).HasName("SYS_C002405817");

            entity.Property(e => e.FK_IDFILM).HasColumnType("NUMBER(38)");
            entity.Property(e => e.FK_IDSCENARISTE).HasColumnType("NUMBER(38)");

            entity.HasOne(d => d.FK_IDFILMNavigation).WithMany(p => p.SCENARISTEFILM)
                .HasForeignKey(d => d.FK_IDFILM)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("SYS_C002405818");

            entity.HasOne(d => d.FK_IDSCENARISTENavigation).WithMany(p => p.SCENARISTEFILM)
                .HasForeignKey(d => d.FK_IDSCENARISTE)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("SYS_C002405819");
        });

        modelBuilder.Entity<UTILISATEUR>(entity =>
        {
            entity.HasKey(e => e.IDUTILISATEUR).HasName("SYS_C002405778");

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
        modelBuilder.HasSequence("ADRESSE_SEQUENCE");
        modelBuilder.HasSequence("LOCATION_SEQUENCE");
        modelBuilder.HasSequence("UTILISATEUR_SEQUENCE");

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}