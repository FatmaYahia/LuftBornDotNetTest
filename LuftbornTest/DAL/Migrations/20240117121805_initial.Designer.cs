﻿// <auto-generated />
using System;
using DAL;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace DAL.Migrations
{
    [DbContext(typeof(DataContext))]
    [Migration("20240117121805_initial")]
    partial class initial
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.12")
                .HasAnnotation("Proxies:ChangeTracking", false)
                .HasAnnotation("Proxies:CheckEquality", false)
                .HasAnnotation("Proxies:LazyLoading", true)
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("Entity.AppModel.Department", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("LastModifiedAt")
                        .HasColumnType("datetime2");

                    b.Property<string>("Location")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Departments");
                });

            modelBuilder.Entity("Entity.AppModel.Employee", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("DateOfBirth")
                        .HasColumnType("datetime2");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("FK_Gender")
                        .HasColumnType("int");

                    b.Property<int>("Fk_Department")
                        .HasColumnType("int");

                    b.Property<string>("FullName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("LastModifiedAt")
                        .HasColumnType("datetime2");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhoneNumber")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("FK_Gender");

                    b.HasIndex("Fk_Department");

                    b.ToTable("Employees");
                });

            modelBuilder.Entity("Entity.AppModel.Gender", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("LastModifiedAt")
                        .HasColumnType("datetime2");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Genders");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CreatedAt = new DateTime(2024, 1, 17, 14, 18, 5, 31, DateTimeKind.Unspecified).AddTicks(232),
                            LastModifiedAt = new DateTime(2024, 1, 17, 14, 18, 5, 31, DateTimeKind.Unspecified).AddTicks(244),
                            Name = "Male"
                        },
                        new
                        {
                            Id = 2,
                            CreatedAt = new DateTime(2024, 1, 17, 14, 18, 5, 31, DateTimeKind.Unspecified).AddTicks(253),
                            LastModifiedAt = new DateTime(2024, 1, 17, 14, 18, 5, 31, DateTimeKind.Unspecified).AddTicks(260),
                            Name = "Female"
                        });
                });

            modelBuilder.Entity("Entity.AuthModel.AccessLevel", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("LastModifiedAt")
                        .HasColumnType("datetime2");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("AccessLevels");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CreatedAt = new DateTime(2024, 1, 17, 14, 18, 5, 30, DateTimeKind.Unspecified).AddTicks(9303),
                            LastModifiedAt = new DateTime(2024, 1, 17, 14, 18, 5, 30, DateTimeKind.Unspecified).AddTicks(9395),
                            Name = "FullAccess"
                        },
                        new
                        {
                            Id = 2,
                            CreatedAt = new DateTime(2024, 1, 17, 14, 18, 5, 30, DateTimeKind.Unspecified).AddTicks(9428),
                            LastModifiedAt = new DateTime(2024, 1, 17, 14, 18, 5, 30, DateTimeKind.Unspecified).AddTicks(9437),
                            Name = "ControlAccess"
                        },
                        new
                        {
                            Id = 3,
                            CreatedAt = new DateTime(2024, 1, 17, 14, 18, 5, 30, DateTimeKind.Unspecified).AddTicks(9446),
                            LastModifiedAt = new DateTime(2024, 1, 17, 14, 18, 5, 30, DateTimeKind.Unspecified).AddTicks(9453),
                            Name = "ViewAccess"
                        });
                });

            modelBuilder.Entity("Entity.AuthModel.SystemUser", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("datetime2");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FullName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("IsActive")
                        .HasColumnType("bit");

                    b.Property<string>("JobTitle")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("LastModifiedAt")
                        .HasColumnType("datetime2");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("SystemUsers");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CreatedAt = new DateTime(2024, 1, 17, 14, 18, 5, 30, DateTimeKind.Unspecified).AddTicks(9800),
                            Email = "Developer@App.com",
                            FullName = "Developer",
                            IsActive = true,
                            JobTitle = "Developer",
                            LastModifiedAt = new DateTime(2024, 1, 17, 14, 18, 5, 30, DateTimeKind.Unspecified).AddTicks(9812),
                            Password = "hahm9974qs"
                        });
                });

            modelBuilder.Entity("Entity.AuthModel.SystemUserPermission", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("datetime2");

                    b.Property<int>("FK_AccessLevel")
                        .HasColumnType("int");

                    b.Property<int>("FK_SystemUser")
                        .HasColumnType("int");

                    b.Property<int>("FK_SystemView")
                        .HasColumnType("int");

                    b.Property<DateTime>("LastModifiedAt")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.HasIndex("FK_AccessLevel");

                    b.HasIndex("FK_SystemUser");

                    b.HasIndex("FK_SystemView");

                    b.ToTable("SystemUserPermissions");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CreatedAt = new DateTime(2024, 1, 17, 14, 18, 5, 31, DateTimeKind.Unspecified).AddTicks(133),
                            FK_AccessLevel = 1,
                            FK_SystemUser = 1,
                            FK_SystemView = 1,
                            LastModifiedAt = new DateTime(2024, 1, 17, 14, 18, 5, 31, DateTimeKind.Unspecified).AddTicks(153)
                        },
                        new
                        {
                            Id = 2,
                            CreatedAt = new DateTime(2024, 1, 17, 14, 18, 5, 31, DateTimeKind.Unspecified).AddTicks(163),
                            FK_AccessLevel = 1,
                            FK_SystemUser = 1,
                            FK_SystemView = 2,
                            LastModifiedAt = new DateTime(2024, 1, 17, 14, 18, 5, 31, DateTimeKind.Unspecified).AddTicks(169)
                        },
                        new
                        {
                            Id = 3,
                            CreatedAt = new DateTime(2024, 1, 17, 14, 18, 5, 31, DateTimeKind.Unspecified).AddTicks(177),
                            FK_AccessLevel = 1,
                            FK_SystemUser = 1,
                            FK_SystemView = 3,
                            LastModifiedAt = new DateTime(2024, 1, 17, 14, 18, 5, 31, DateTimeKind.Unspecified).AddTicks(183)
                        });
                });

            modelBuilder.Entity("Entity.AuthModel.SystemView", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("LastModifiedAt")
                        .HasColumnType("datetime2");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("SystemViews");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CreatedAt = new DateTime(2024, 1, 17, 14, 18, 5, 30, DateTimeKind.Unspecified).AddTicks(9696),
                            LastModifiedAt = new DateTime(2024, 1, 17, 14, 18, 5, 30, DateTimeKind.Unspecified).AddTicks(9714),
                            Name = "Home"
                        },
                        new
                        {
                            Id = 2,
                            CreatedAt = new DateTime(2024, 1, 17, 14, 18, 5, 30, DateTimeKind.Unspecified).AddTicks(9724),
                            LastModifiedAt = new DateTime(2024, 1, 17, 14, 18, 5, 30, DateTimeKind.Unspecified).AddTicks(9731),
                            Name = "SystemView"
                        },
                        new
                        {
                            Id = 3,
                            CreatedAt = new DateTime(2024, 1, 17, 14, 18, 5, 30, DateTimeKind.Unspecified).AddTicks(9739),
                            LastModifiedAt = new DateTime(2024, 1, 17, 14, 18, 5, 30, DateTimeKind.Unspecified).AddTicks(9745),
                            Name = "SystemUser"
                        });
                });

            modelBuilder.Entity("Entity.AppModel.Employee", b =>
                {
                    b.HasOne("Entity.AppModel.Gender", "Gender")
                        .WithMany("Employees")
                        .HasForeignKey("FK_Gender")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Entity.AppModel.Department", "Department")
                        .WithMany("Employees")
                        .HasForeignKey("Fk_Department")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Department");

                    b.Navigation("Gender");
                });

            modelBuilder.Entity("Entity.AuthModel.SystemUserPermission", b =>
                {
                    b.HasOne("Entity.AuthModel.AccessLevel", "AccessLevel")
                        .WithMany("SystemUserPermissions")
                        .HasForeignKey("FK_AccessLevel")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Entity.AuthModel.SystemUser", "SystemUser")
                        .WithMany("SystemUserPermissions")
                        .HasForeignKey("FK_SystemUser")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Entity.AuthModel.SystemView", "SystemView")
                        .WithMany("SystemUserPermissions")
                        .HasForeignKey("FK_SystemView")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("AccessLevel");

                    b.Navigation("SystemUser");

                    b.Navigation("SystemView");
                });

            modelBuilder.Entity("Entity.AppModel.Department", b =>
                {
                    b.Navigation("Employees");
                });

            modelBuilder.Entity("Entity.AppModel.Gender", b =>
                {
                    b.Navigation("Employees");
                });

            modelBuilder.Entity("Entity.AuthModel.AccessLevel", b =>
                {
                    b.Navigation("SystemUserPermissions");
                });

            modelBuilder.Entity("Entity.AuthModel.SystemUser", b =>
                {
                    b.Navigation("SystemUserPermissions");
                });

            modelBuilder.Entity("Entity.AuthModel.SystemView", b =>
                {
                    b.Navigation("SystemUserPermissions");
                });
#pragma warning restore 612, 618
        }
    }
}
