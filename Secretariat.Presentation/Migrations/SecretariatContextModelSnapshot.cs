﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Secretariat.Presentation.Context;

namespace Secretariat.Presentation.Migrations
{
    [DbContext(typeof(SecretariatContext))]
    partial class SecretariatContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.6")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("EmployéEntityRéunionEntity", b =>
                {
                    b.Property<long>("EmployésIdPersonne")
                        .HasColumnType("bigint");

                    b.Property<long>("RéunionsIdEvenement")
                        .HasColumnType("bigint");

                    b.HasKey("EmployésIdPersonne", "RéunionsIdEvenement");

                    b.HasIndex("RéunionsIdEvenement");

                    b.ToTable("EmployéEntityRéunionEntity");
                });

            modelBuilder.Entity("Secretariat.Infra.Domain.Models.AgendaEntity", b =>
                {
                    b.Property<int>("IdAgenda")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("id")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Login")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)")
                        .HasColumnName("login");

                    b.Property<string>("MotdePass")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)")
                        .HasColumnName("mot_de_pass");

                    b.HasKey("IdAgenda");

                    b.ToTable("agenda");
                });

            modelBuilder.Entity("Secretariat.Infra.Domain.Models.ContactEntity", b =>
                {
                    b.Property<long>("IdContact")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .HasColumnName("id")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Adresse")
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("adresse");

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("email");

                    b.Property<string>("Tel")
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("tel");

                    b.HasKey("IdContact");

                    b.ToTable("contact");
                });

            modelBuilder.Entity("Secretariat.Infra.Domain.Models.EntrepriseEntity", b =>
                {
                    b.Property<long>("IdEntreprise")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .HasColumnName("id")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<long?>("ContactIdContact")
                        .HasColumnType("bigint");

                    b.Property<string>("Nom")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("nom");

                    b.HasKey("IdEntreprise");

                    b.HasIndex("ContactIdContact");

                    b.ToTable("entreprise");
                });

            modelBuilder.Entity("Secretariat.Infra.Domain.Models.EvenementEntity", b =>
                {
                    b.Property<long>("IdEvenement")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .HasColumnName("id")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("DateEvent")
                        .HasColumnType("datetime2")
                        .HasColumnName("evenement_date");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("description");

                    b.Property<DateTime>("TimeEvent")
                        .HasColumnType("datetime2")
                        .HasColumnName("evenement_time");

                    b.Property<string>("TitreEvenement")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("evenement_titre");

                    b.Property<int?>("evenement_agenda_id")
                        .HasColumnType("int");

                    b.HasKey("IdEvenement");

                    b.HasIndex("evenement_agenda_id");

                    b.ToTable("evenement");
                });

            modelBuilder.Entity("Secretariat.Infra.Domain.Models.PersonneEntity", b =>
                {
                    b.Property<long>("IdPersonne")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .HasColumnName("id")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<long?>("ContactIdContact")
                        .HasColumnType("bigint");

                    b.Property<string>("Nom")
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("nom");

                    b.Property<string>("Prénom")
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("prénom");

                    b.HasKey("IdPersonne");

                    b.HasIndex("ContactIdContact");

                    b.ToTable("personne");
                });

            modelBuilder.Entity("Secretariat.Infra.Domain.Models.RendezvousEntity", b =>
                {
                    b.HasBaseType("Secretariat.Infra.Domain.Models.EvenementEntity");

                    b.Property<long?>("client_rendezvous_id")
                        .HasColumnType("bigint");

                    b.HasIndex("client_rendezvous_id");

                    b.ToTable("rendezvous");
                });

            modelBuilder.Entity("Secretariat.Infra.Domain.Models.RéunionEntity", b =>
                {
                    b.HasBaseType("Secretariat.Infra.Domain.Models.EvenementEntity");

                    b.ToTable("réunion");
                });

            modelBuilder.Entity("Secretariat.Infra.Domain.Models.VisiteEntity", b =>
                {
                    b.HasBaseType("Secretariat.Infra.Domain.Models.EvenementEntity");

                    b.Property<long?>("EntrepriseIdEntreprise")
                        .HasColumnType("bigint");

                    b.Property<string>("RapportVisite")
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("rapport_visite");

                    b.HasIndex("EntrepriseIdEntreprise");

                    b.ToTable("visite");
                });

            modelBuilder.Entity("Secretariat.Infra.Domain.Models.ClientEntity", b =>
                {
                    b.HasBaseType("Secretariat.Infra.Domain.Models.PersonneEntity");

                    b.ToTable("client");
                });

            modelBuilder.Entity("Secretariat.Infra.Domain.Models.EmployéEntity", b =>
                {
                    b.HasBaseType("Secretariat.Infra.Domain.Models.PersonneEntity");

                    b.Property<double>("Salaire")
                        .HasColumnType("float")
                        .HasColumnName("salaire");

                    b.ToTable("employé");
                });

            modelBuilder.Entity("EmployéEntityRéunionEntity", b =>
                {
                    b.HasOne("Secretariat.Infra.Domain.Models.EmployéEntity", null)
                        .WithMany()
                        .HasForeignKey("EmployésIdPersonne")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Secretariat.Infra.Domain.Models.RéunionEntity", null)
                        .WithMany()
                        .HasForeignKey("RéunionsIdEvenement")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Secretariat.Infra.Domain.Models.EntrepriseEntity", b =>
                {
                    b.HasOne("Secretariat.Infra.Domain.Models.ContactEntity", "Contact")
                        .WithMany()
                        .HasForeignKey("ContactIdContact");

                    b.Navigation("Contact");
                });

            modelBuilder.Entity("Secretariat.Infra.Domain.Models.EvenementEntity", b =>
                {
                    b.HasOne("Secretariat.Infra.Domain.Models.AgendaEntity", "Agenda")
                        .WithMany("Evenements")
                        .HasForeignKey("evenement_agenda_id")
                        .HasConstraintName("evenement_agenda_fk")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.Navigation("Agenda");
                });

            modelBuilder.Entity("Secretariat.Infra.Domain.Models.PersonneEntity", b =>
                {
                    b.HasOne("Secretariat.Infra.Domain.Models.ContactEntity", "Contact")
                        .WithMany()
                        .HasForeignKey("ContactIdContact");

                    b.Navigation("Contact");
                });

            modelBuilder.Entity("Secretariat.Infra.Domain.Models.RendezvousEntity", b =>
                {
                    b.HasOne("Secretariat.Infra.Domain.Models.EvenementEntity", null)
                        .WithOne()
                        .HasForeignKey("Secretariat.Infra.Domain.Models.RendezvousEntity", "IdEvenement")
                        .OnDelete(DeleteBehavior.ClientCascade)
                        .IsRequired();

                    b.HasOne("Secretariat.Infra.Domain.Models.ClientEntity", "Client")
                        .WithMany("Rendezvouss")
                        .HasForeignKey("client_rendezvous_id")
                        .HasConstraintName("client_rendezvous_fk")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.Navigation("Client");
                });

            modelBuilder.Entity("Secretariat.Infra.Domain.Models.RéunionEntity", b =>
                {
                    b.HasOne("Secretariat.Infra.Domain.Models.EvenementEntity", null)
                        .WithOne()
                        .HasForeignKey("Secretariat.Infra.Domain.Models.RéunionEntity", "IdEvenement")
                        .OnDelete(DeleteBehavior.ClientCascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Secretariat.Infra.Domain.Models.VisiteEntity", b =>
                {
                    b.HasOne("Secretariat.Infra.Domain.Models.EntrepriseEntity", "Entreprise")
                        .WithMany()
                        .HasForeignKey("EntrepriseIdEntreprise");

                    b.HasOne("Secretariat.Infra.Domain.Models.EvenementEntity", null)
                        .WithOne()
                        .HasForeignKey("Secretariat.Infra.Domain.Models.VisiteEntity", "IdEvenement")
                        .OnDelete(DeleteBehavior.ClientCascade)
                        .IsRequired();

                    b.Navigation("Entreprise");
                });

            modelBuilder.Entity("Secretariat.Infra.Domain.Models.ClientEntity", b =>
                {
                    b.HasOne("Secretariat.Infra.Domain.Models.PersonneEntity", null)
                        .WithOne()
                        .HasForeignKey("Secretariat.Infra.Domain.Models.ClientEntity", "IdPersonne")
                        .OnDelete(DeleteBehavior.ClientCascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Secretariat.Infra.Domain.Models.EmployéEntity", b =>
                {
                    b.HasOne("Secretariat.Infra.Domain.Models.PersonneEntity", null)
                        .WithOne()
                        .HasForeignKey("Secretariat.Infra.Domain.Models.EmployéEntity", "IdPersonne")
                        .OnDelete(DeleteBehavior.ClientCascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Secretariat.Infra.Domain.Models.AgendaEntity", b =>
                {
                    b.Navigation("Evenements");
                });

            modelBuilder.Entity("Secretariat.Infra.Domain.Models.ClientEntity", b =>
                {
                    b.Navigation("Rendezvouss");
                });
#pragma warning restore 612, 618
        }
    }
}
