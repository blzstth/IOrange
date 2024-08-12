﻿// <auto-generated />
using IOrange.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace IOrange.Migrations
{
    [DbContext(typeof(IorangedatabaseContext))]
    [Migration("20240812164605_Addamountanddatetime")]
    partial class Addamountanddatetime
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .UseCollation("utf8mb4_0900_ai_ci")
                .HasAnnotation("ProductVersion", "8.0.7")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            MySqlModelBuilderExtensions.HasCharSet(modelBuilder, "utf8mb4");
            MySqlModelBuilderExtensions.AutoIncrementColumns(modelBuilder);

            modelBuilder.Entity("IOrange.Data.Bar", b =>
                {
                    b.Property<int>("Bid")
                        .HasColumnType("int")
                        .HasColumnName("BId");

                    b.Property<float>("Income")
                        .HasColumnType("float")
                        .HasColumnName("income");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("varchar(255)")
                        .HasColumnName("name");

                    b.HasKey("Bid")
                        .HasName("PRIMARY");

                    b.ToTable("bar", (string)null);
                });

            modelBuilder.Entity("IOrange.Data.Efmigrationshistory", b =>
                {
                    b.Property<string>("MigrationId")
                        .HasMaxLength(150)
                        .HasColumnType("varchar(150)");

                    b.Property<string>("ProductVersion")
                        .IsRequired()
                        .HasMaxLength(32)
                        .HasColumnType("varchar(32)");

                    b.HasKey("MigrationId")
                        .HasName("PRIMARY");

                    b.ToTable("__efmigrationshistory", (string)null);
                });

            modelBuilder.Entity("IOrange.Data.Employee", b =>
                {
                    b.Property<int>("Eid")
                        .HasColumnType("int")
                        .HasColumnName("EId");

                    b.Property<int>("Bid")
                        .HasColumnType("int")
                        .HasColumnName("BId");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("varchar(255)");

                    b.Property<int>("Pid")
                        .HasColumnType("int")
                        .HasColumnName("PId");

                    b.Property<float>("Totalincome")
                        .HasColumnType("float")
                        .HasColumnName("totalincome");

                    b.HasKey("Eid")
                        .HasName("PRIMARY");

                    b.ToTable("employee", (string)null);
                });

            modelBuilder.Entity("IOrange.Data.Item", b =>
                {
                    b.Property<int>("Iid")
                        .HasColumnType("int")
                        .HasColumnName("IId");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("varchar(255)")
                        .HasColumnName("name");

                    b.Property<float>("Price")
                        .HasColumnType("float")
                        .HasColumnName("price");

                    b.Property<int>("Sold")
                        .HasColumnType("int")
                        .HasColumnName("sold");

                    b.HasKey("Iid")
                        .HasName("PRIMARY");

                    b.ToTable("items", (string)null);
                });

            modelBuilder.Entity("IOrange.Data.Rang", b =>
                {
                    b.Property<int>("Pid")
                        .HasColumnType("int")
                        .HasColumnName("PId");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("varchar(255)")
                        .HasColumnName("title");

                    b.HasKey("Pid")
                        .HasName("PRIMARY");

                    b.ToTable("rangs", (string)null);
                });

            modelBuilder.Entity("IOrange.Data.Transaction", b =>
                {
                    b.Property<int>("Tid")
                        .HasColumnType("int")
                        .HasColumnName("TId");

                    b.Property<int>("Bid")
                        .HasColumnType("int")
                        .HasColumnName("BId");

                    b.Property<int>("Eid")
                        .HasColumnType("int")
                        .HasColumnName("EId");

                    b.Property<float>("Total")
                        .HasColumnType("float")
                        .HasColumnName("total");

                    b.HasKey("Tid")
                        .HasName("PRIMARY");

                    b.ToTable("transactions", (string)null);
                });
#pragma warning restore 612, 618
        }
    }
}
