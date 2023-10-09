using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace Entity;

public partial class WorkContext : DbContext
{
    public WorkContext()
    {
    }

    public WorkContext(DbContextOptions<WorkContext> options)
        : base(options)
    {
    }

    public virtual DbSet<BusinessTbl> Business { get; set; }

    public virtual DbSet<LanguageTbl> Language { get; set; }

    public virtual DbSet<User1Tbl> Users1 { get; set; }

    public virtual DbSet<UserPropertyTbl> UserProperties { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    { 
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("Data Source=B11;Initial Catalog=work;Integrated Security=True;TrustServerCertificate=True");
    }
    //protected override void OnModelCreating(ModelBuilder modelBuilder)
    //{
    //    modelBuilder.UseCollation("Hebrew_100_CI_AS");

    //    modelBuilder.Entity<BusinessTbl>(entity =>
    //    {
    //        entity
    //            .HasNoKey()
    //            .ToTable("Business_tbl");

    //        entity.Property(e => e.BusinessCity)
    //            .HasMaxLength(9)
    //            .HasColumnName("businessCity");
    //        entity.Property(e => e.BusinessId)
    //            .HasMaxLength(9)
    //            .HasColumnName("businessId");
    //        entity.Property(e => e.BusinessName)
    //            .HasMaxLength(9)
    //            .HasColumnName("businessName");
    //        entity.Property(e => e.LanguageId)
    //            .HasMaxLength(9)
    //            .HasColumnName("languageId");
    //        entity.Property(e => e.NumWeekHours).HasColumnName("numWeekHours");
    //        entity.Property(e => e.ProfessionType).HasColumnName("professionType");
    //        entity.Property(e => e.SalaryHour).HasColumnName("salaryHour");
    //        entity.Property(e => e.SeniorityBusiness).HasColumnName("seniorityBusiness");
    //    });

    //    modelBuilder.Entity<LanguageTbl>(entity =>
    //    {
    //        entity
    //            .HasNoKey()
    //            .ToTable("language1");

    //        entity.Property(e => e.Discription)
    //            .HasMaxLength(9)
    //            .HasColumnName("discription");
    //        entity.Property(e => e.LanguageId)
    //            .HasMaxLength(9)
    //            .HasColumnName("languageId");
    //    });

    //    modelBuilder.Entity<User1Tbl>(entity =>
    //    {
    //        entity
    //            .HasNoKey()
    //            .ToTable("User1");

    //        entity.Property(e => e.Age).HasColumnName("age");
    //        entity.Property(e => e.ExpectationsSalary).HasColumnName("expectationsSalary");
    //        entity.Property(e => e.Mail)
    //            .HasMaxLength(20)
    //            .HasColumnName("mail");
    //        entity.Property(e => e.Name1)
    //            .HasMaxLength(20)
    //            .HasColumnName("name1");
    //        entity.Property(e => e.Phone)
    //            .HasMaxLength(10)
    //            .HasColumnName("phone");
    //        entity.Property(e => e.ProfessionType).HasColumnName("professionType");
    //        entity.Property(e => e.UserCity)
    //            .HasMaxLength(15)
    //            .HasColumnName("userCity");
    //        entity.Property(e => e.UserId)
    //            .HasMaxLength(9)
    //            .HasColumnName("userId");
    //        entity.Property(e => e.UserName)
    //            .HasMaxLength(20)
    //            .HasColumnName("userName");
    //        entity.Property(e => e.UserPassword)
    //            .HasMaxLength(20)
    //            .HasColumnName("userPassword");
    //        entity.Property(e => e.UserSeniority).HasColumnName("userSeniority");
    //    });

    //    modelBuilder.Entity<UserPropertyTblDto>(entity =>
    //    {
    //        entity.HasNoKey();

    //        entity.Property(e => e.Diploma)
    //            .HasMaxLength(30)
    //            .HasColumnName("diploma");
    //        entity.Property(e => e.LanguageId)
    //            .HasMaxLength(9)
    //            .HasColumnName("languageId");
    //        entity.Property(e => e.NumMonthLearn).HasColumnName("numMonthLearn");
    //        entity.Property(e => e.SeniorityLanguage).HasColumnName("seniorityLanguage");
    //        entity.Property(e => e.UserId)
    //            .HasMaxLength(9)
    //            .HasColumnName("userId");
    //        entity.Property(e => e.UserPropertiesId).HasMaxLength(30);
    //    });

    //    OnModelCreatingPartial(modelBuilder);
    //}

    //partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
