﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using TaxiDispecer.Models;

namespace TaxiDispecer.Migrations
{
    [DbContext(typeof(DatabaseContext))]
    [Migration("20190619085507_migracija")]
    partial class migracija
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.4-servicing-10062")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("TaxiDispecer.Models.Administrator", b =>
                {
                    b.Property<int>("AdministratorID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("Password");

                    b.Property<int>("PermissionLevel");

                    b.Property<int>("Username");

                    b.HasKey("AdministratorID");

                    b.ToTable("Administrator");
                });

            modelBuilder.Entity("TaxiDispecer.Models.Logiranja", b =>
                {
                    b.Property<int>("LogiranjaID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("DateTime");

                    b.Property<int>("OsobaID");

                    b.HasKey("LogiranjaID");

                    b.HasIndex("OsobaID");

                    b.ToTable("Logiranja");
                });

            modelBuilder.Entity("TaxiDispecer.Models.Narudzba", b =>
                {
                    b.Property<int>("NarudzbaID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("DateTime");

                    b.Property<int>("KlijentID");

                    b.Property<string>("OdredisnaLokacija");

                    b.Property<string>("PocetnaLokacija");

                    b.HasKey("NarudzbaID");

                    b.HasIndex("KlijentID");

                    b.ToTable("Narudzba");
                });

            modelBuilder.Entity("TaxiDispecer.Models.Obavijest", b =>
                {
                    b.Property<int>("ObavijestID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("DateTime");

                    b.Property<int>("OsobaID");

                    b.Property<string>("TekstObavijesti");

                    b.HasKey("ObavijestID");

                    b.HasIndex("OsobaID");

                    b.ToTable("Obavijest");
                });

            modelBuilder.Entity("TaxiDispecer.Models.OcjenaVozaca", b =>
                {
                    b.Property<int>("OcjenaVozacaID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("KlijentID");

                    b.Property<string>("Komentar");

                    b.Property<int>("Ocjena");

                    b.Property<int?>("VozacID");

                    b.Property<int?>("VoznjaID");

                    b.HasKey("OcjenaVozacaID");

                    b.HasIndex("KlijentID");

                    b.HasIndex("VozacID");

                    b.HasIndex("VoznjaID");

                    b.ToTable("OcjenaVozaca");
                });

            modelBuilder.Entity("TaxiDispecer.Models.Osoba", b =>
                {
                    b.Property<int>("OsobaID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("DateTime");

                    b.Property<string>("Discriminator")
                        .IsRequired();

                    b.Property<string>("EMail");

                    b.Property<string>("Ime");

                    b.Property<string>("JMBG");

                    b.Property<string>("Prezime");

                    b.Property<string>("Sifra");

                    b.Property<string>("Username");

                    b.HasKey("OsobaID");

                    b.ToTable("Osoba");

                    b.HasDiscriminator<string>("Discriminator").HasValue("Osoba");
                });

            modelBuilder.Entity("TaxiDispecer.Models.Voznja", b =>
                {
                    b.Property<int>("VoznjaID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("Aktivna");

                    b.Property<int>("NarudzbaID");

                    b.Property<int?>("VozacID");

                    b.HasKey("VoznjaID");

                    b.HasIndex("NarudzbaID");

                    b.HasIndex("VozacID");

                    b.ToTable("Voznja");
                });

            modelBuilder.Entity("TaxiDispecer.Models.Klijent", b =>
                {
                    b.HasBaseType("TaxiDispecer.Models.Osoba");

                    b.ToTable("Klijent");

                    b.HasDiscriminator().HasValue("Klijent");
                });

            modelBuilder.Entity("TaxiDispecer.Models.Vozac", b =>
                {
                    b.HasBaseType("TaxiDispecer.Models.Osoba");

                    b.Property<string>("BrojLicence");

                    b.Property<string>("BrojTransakcijskogRacuna");

                    b.Property<string>("BrojUgovora");

                    b.ToTable("Vozac");

                    b.HasDiscriminator().HasValue("Vozac");
                });

            modelBuilder.Entity("TaxiDispecer.Models.Logiranja", b =>
                {
                    b.HasOne("TaxiDispecer.Models.Osoba", "Osoba")
                        .WithMany()
                        .HasForeignKey("OsobaID")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("TaxiDispecer.Models.Narudzba", b =>
                {
                    b.HasOne("TaxiDispecer.Models.Klijent", "Klijent")
                        .WithMany()
                        .HasForeignKey("KlijentID")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("TaxiDispecer.Models.Obavijest", b =>
                {
                    b.HasOne("TaxiDispecer.Models.Osoba", "Osoba")
                        .WithMany()
                        .HasForeignKey("OsobaID")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("TaxiDispecer.Models.OcjenaVozaca", b =>
                {
                    b.HasOne("TaxiDispecer.Models.Klijent", "Klijent")
                        .WithMany()
                        .HasForeignKey("KlijentID");

                    b.HasOne("TaxiDispecer.Models.Vozac", "Vozac")
                        .WithMany()
                        .HasForeignKey("VozacID");

                    b.HasOne("TaxiDispecer.Models.Voznja", "Voznja")
                        .WithMany()
                        .HasForeignKey("VoznjaID");
                });

            modelBuilder.Entity("TaxiDispecer.Models.Voznja", b =>
                {
                    b.HasOne("TaxiDispecer.Models.Narudzba", "Narudzba")
                        .WithMany()
                        .HasForeignKey("NarudzbaID")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("TaxiDispecer.Models.Vozac", "Vozac")
                        .WithMany()
                        .HasForeignKey("VozacID");
                });
#pragma warning restore 612, 618
        }
    }
}
