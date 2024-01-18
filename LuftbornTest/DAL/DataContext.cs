using Common;
using Entity.AppModel;
using Entity.AuthModel;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Common.DataEnum;

namespace DAL
{
    public class DataContext:DbContext
    {
        public DataContext(DbContextOptions options):base(options)
        {
            
        }
        public virtual DbSet<Department> Departments { get; set; }  
        public virtual DbSet<Employee> Employees { get; set; }
        public virtual DbSet<Gender> Genders { get; set; }
        public virtual DbSet<AccessLevel> AccessLevels { get; set; }
        public virtual DbSet<SystemUser> SystemUsers { get; set; }
        public virtual DbSet<SystemUserPermission> SystemUserPermissions { get; set; }
        public virtual DbSet<SystemView> SystemViews { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<AccessLevel>()
                .HasData(
                new AccessLevel
                {
                    Id = (int)AccessLevelEnum.FullAccess,
                    Name = "FullAccess"
                },
                new AccessLevel
                {
                    Id = (int)AccessLevelEnum.ControlAccess,
                    Name = "ControlAccess"
                }, new AccessLevel
                {
                    Id = (int)AccessLevelEnum.ViewAccess,
                    Name = "ViewAccess"
                });
            modelBuilder.Entity<SystemView>()
                .HasData(
                    new SystemView
                    {
                        Id=(int)SystemViewEnum.Home,
                        Name="Home"
                    },
                     new SystemView
                     {
                         Id = (int)SystemViewEnum.SystemView,
                         Name = "SystemView"
                     }, new SystemView
                     {
                         Id = (int)SystemViewEnum.SystemUser,
                         Name = "SystemUser"
                     }
                    );
            modelBuilder.Entity<SystemUser>()
               .HasData(
                new SystemUser
                {
                    Id = 1,
                    Email = "Developer@App.com",
                    FullName = "Developer",
                    JobTitle = "Developer",
                    Password = RandomGenerator.RandomKey(),
                    IsActive = true,
                }
               );
            modelBuilder.Entity<SystemUserPermission>()
              .HasData(
               new SystemUserPermission
               {
                   Id = 1,
                   FK_SystemUser = 1,
                   FK_AccessLevel = (int)AccessLevelEnum.FullAccess,
                   FK_SystemView = (int)SystemViewEnum.Home,
               },
              new SystemUserPermission
              {
                  Id = 2,
                  FK_SystemUser = 1,
                  FK_AccessLevel = (int)AccessLevelEnum.FullAccess,
                  FK_SystemView = (int)SystemViewEnum.SystemView,
              },
              new SystemUserPermission
              {
                  Id = 3,
                  FK_SystemUser = 1,
                  FK_AccessLevel = (int)AccessLevelEnum.FullAccess,
                  FK_SystemView = (int)SystemViewEnum.SystemUser,
              }
              );
            modelBuilder.Entity<Gender>()
                .HasData(
                new Gender
                {
                    Id = (int)GenderEnum.Male,
                    Name = "Male"
                },
                 new Gender
                 {
                     Id = (int)GenderEnum.Female,
                     Name = "Female"
                 }
                );
        }
    }
}
