﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using notesAndLedgersApp.Server.Data;

#nullable disable

namespace notesAndLedgersApp.Server.Migrations
{
    [DbContext(typeof(DataContext))]
    [Migration("20221105195359_CampaignUpdate")]
    partial class CampaignUpdate
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.0-rc.2.22472.11")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("notesAndLedgersApp.Shared.Campaign", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int?>("CharacterId")
                        .HasColumnType("int");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("EndDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("StartDate")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.HasIndex("CharacterId");

                    b.ToTable("Campaigns");
                });

            modelBuilder.Entity("notesAndLedgersApp.Shared.Character", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("CoinPurseId")
                        .HasColumnType("int");

                    b.Property<int>("CurrentClass")
                        .HasColumnType("int");

                    b.Property<int>("Level")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("CoinPurseId");

                    b.ToTable("Character");
                });

            modelBuilder.Entity("notesAndLedgersApp.Shared.CoinPurse", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("Copper")
                        .HasColumnType("int");

                    b.Property<int>("Gold")
                        .HasColumnType("int");

                    b.Property<int>("Silver")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("CoinPurse");
                });

            modelBuilder.Entity("notesAndLedgersApp.Shared.Note", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Content")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("SessionId")
                        .HasColumnType("int");

                    b.Property<string>("Title")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("SessionId");

                    b.ToTable("Note");
                });

            modelBuilder.Entity("notesAndLedgersApp.Shared.Session", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int?>("CampaignId")
                        .HasColumnType("int");

                    b.Property<string>("SessionComments")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("SessionDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("SessionName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("CampaignId");

                    b.ToTable("Session");
                });

            modelBuilder.Entity("notesAndLedgersApp.Shared.Transaction", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<float>("Amount")
                        .HasColumnType("real");

                    b.Property<int?>("CoinPurseId")
                        .HasColumnType("int");

                    b.Property<string>("Comment")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("SessionId")
                        .HasColumnType("int");

                    b.Property<int>("Type")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("CoinPurseId");

                    b.HasIndex("SessionId");

                    b.ToTable("Transaction");
                });

            modelBuilder.Entity("notesAndLedgersApp.Shared.Campaign", b =>
                {
                    b.HasOne("notesAndLedgersApp.Shared.Character", "Character")
                        .WithMany()
                        .HasForeignKey("CharacterId");

                    b.Navigation("Character");
                });

            modelBuilder.Entity("notesAndLedgersApp.Shared.Character", b =>
                {
                    b.HasOne("notesAndLedgersApp.Shared.CoinPurse", "CoinPurse")
                        .WithMany()
                        .HasForeignKey("CoinPurseId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("CoinPurse");
                });

            modelBuilder.Entity("notesAndLedgersApp.Shared.Note", b =>
                {
                    b.HasOne("notesAndLedgersApp.Shared.Session", null)
                        .WithMany("SessionNotes")
                        .HasForeignKey("SessionId");
                });

            modelBuilder.Entity("notesAndLedgersApp.Shared.Session", b =>
                {
                    b.HasOne("notesAndLedgersApp.Shared.Campaign", null)
                        .WithMany("Session")
                        .HasForeignKey("CampaignId");
                });

            modelBuilder.Entity("notesAndLedgersApp.Shared.Transaction", b =>
                {
                    b.HasOne("notesAndLedgersApp.Shared.CoinPurse", null)
                        .WithMany("Transactions")
                        .HasForeignKey("CoinPurseId");

                    b.HasOne("notesAndLedgersApp.Shared.Session", null)
                        .WithMany("Transactions")
                        .HasForeignKey("SessionId");
                });

            modelBuilder.Entity("notesAndLedgersApp.Shared.Campaign", b =>
                {
                    b.Navigation("Session");
                });

            modelBuilder.Entity("notesAndLedgersApp.Shared.CoinPurse", b =>
                {
                    b.Navigation("Transactions");
                });

            modelBuilder.Entity("notesAndLedgersApp.Shared.Session", b =>
                {
                    b.Navigation("SessionNotes");

                    b.Navigation("Transactions");
                });
#pragma warning restore 612, 618
        }
    }
}
