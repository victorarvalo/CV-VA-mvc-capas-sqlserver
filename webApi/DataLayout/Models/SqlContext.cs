using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace DataLayout.Models;

public partial class SqlContext : DbContext
{
    public SqlContext()
    {
    }

    public SqlContext(DbContextOptions<SqlContext> options)
        : base(options)
    {
    }

    public virtual DbSet<DetailSummary> DetailSummaries { get; set; }

    public virtual DbSet<EducationDatum> EducationData { get; set; }

    public virtual DbSet<Email> Emails { get; set; }

    public virtual DbSet<ExperienceDatum> ExperienceData { get; set; }

    public virtual DbSet<ModalityTraining> ModalityTrainings { get; set; }

    public virtual DbSet<PersonalDatum> PersonalData { get; set; }

    public virtual DbSet<PersonalReference> PersonalReferences { get; set; }

    public virtual DbSet<Skill> Skills { get; set; }

    public virtual DbSet<SummaryDatum> SummaryData { get; set; }

    public virtual DbSet<TypeTraining> TypeTrainings { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see https://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("Server=tcp:hvvaserver.database.windows.net,1433;Initial Catalog=hvvaserver;Persist Security Info=False;User ID=CloudSA51b3dab5;Password=Aa1004794.;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<DetailSummary>(entity =>
        {
            entity.ToTable("DetailSummary");

            entity.Property(e => e.DetailSummaryId).HasColumnName("detailSummaryId");
            entity.Property(e => e.Detail)
                .IsUnicode(false)
                .HasColumnName("detail");
            entity.Property(e => e.ExperienceDataId).HasColumnName("experienceDataId");

            entity.HasOne(d => d.ExperienceData).WithMany(p => p.DetailSummaries)
                .HasForeignKey(d => d.ExperienceDataId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_DetailSummary_ExperienceData");
        });

        modelBuilder.Entity<EducationDatum>(entity =>
        {
            entity.HasKey(e => e.EducationDataId);

            entity.Property(e => e.EducationDataId).HasColumnName("educationDataId");
            entity.Property(e => e.FinishDate)
                .HasColumnType("datetime")
                .HasColumnName("finishDate");
            entity.Property(e => e.Institution)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("institution");
            entity.Property(e => e.ModalityTrainingId).HasColumnName("modalityTrainingId");
            entity.Property(e => e.StartDate)
                .HasColumnType("datetime")
                .HasColumnName("startDate");
            entity.Property(e => e.Summary)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("summary");
            entity.Property(e => e.Title)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("title");
            entity.Property(e => e.TypeTrainingId).HasColumnName("typeTrainingId");

            entity.HasOne(d => d.ModalityTraining).WithMany(p => p.EducationData)
                .HasForeignKey(d => d.ModalityTrainingId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_EducationData_ModalityTraining");

            entity.HasOne(d => d.TypeTraining).WithMany(p => p.EducationData)
                .HasForeignKey(d => d.TypeTrainingId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_EducationData_TypeTraining");
        });

        modelBuilder.Entity<Email>(entity =>
        {
            entity.ToTable("emails");

            entity.Property(e => e.EmailId).HasColumnName("emailId");
            entity.Property(e => e.Email1)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("email");
            entity.Property(e => e.PersonalDataId).HasColumnName("personalDataId");

            entity.HasOne(d => d.PersonalData).WithMany(p => p.Emails)
                .HasForeignKey(d => d.PersonalDataId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_emails_PersonalData");
        });

        modelBuilder.Entity<ExperienceDatum>(entity =>
        {
            entity.HasKey(e => e.ExperienceDataId);

            entity.Property(e => e.ExperienceDataId).HasColumnName("experienceDataId");
            entity.Property(e => e.Enterprise)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("enterprise");
            entity.Property(e => e.FinishDate)
                .HasColumnType("datetime")
                .HasColumnName("finishDate");
            entity.Property(e => e.Phone)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("phone");
            entity.Property(e => e.Position)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("position");
            entity.Property(e => e.StartDate)
                .HasColumnType("datetime")
                .HasColumnName("startDate");
            entity.Property(e => e.Summary)
                .IsUnicode(false)
                .HasColumnName("summary");
            entity.Property(e => e.Url)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("url");
        });

        modelBuilder.Entity<ModalityTraining>(entity =>
        {
            entity.ToTable("ModalityTraining");

            entity.Property(e => e.ModalityTrainingId).HasColumnName("modalityTrainingId");
            entity.Property(e => e.Modality)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("modality");
        });

        modelBuilder.Entity<PersonalDatum>(entity =>
        {
            entity.HasKey(e => e.PersonalDataId);

            entity.Property(e => e.PersonalDataId).HasColumnName("personalDataId");
            entity.Property(e => e.Address)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("address");
            entity.Property(e => e.Age).HasColumnName("age");
            entity.Property(e => e.BornDate)
                .HasColumnType("datetime")
                .HasColumnName("bornDate");
            entity.Property(e => e.BornPlace)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("bornPlace");
            entity.Property(e => e.CelPhone)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("celPhone");
            entity.Property(e => e.IdDocument)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("idDocument");
            entity.Property(e => e.Lastname)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("lastname");
            entity.Property(e => e.PersonalName)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("personalName");
        });

        modelBuilder.Entity<PersonalReference>(entity =>
        {
            entity.ToTable("PersonalReference");

            entity.Property(e => e.PersonalReferenceId).HasColumnName("personalReferenceId");
            entity.Property(e => e.Celphone)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("celphone");
            entity.Property(e => e.Email)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("email");
            entity.Property(e => e.Occupation)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("occupation");
            entity.Property(e => e.PersonalReferenceName)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("personalReferenceName");
        });

        modelBuilder.Entity<Skill>(entity =>
        {
            entity.HasKey(e => e.SkillsId);

            entity.Property(e => e.SkillsId).HasColumnName("skillsId");
            entity.Property(e => e.ExperienceDataId).HasColumnName("experienceDataId");
            entity.Property(e => e.Skill1)
                .IsUnicode(false)
                .HasColumnName("skill");

            entity.HasOne(d => d.ExperienceData).WithMany(p => p.Skills)
                .HasForeignKey(d => d.ExperienceDataId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Skills_ExperienceData");
        });

        modelBuilder.Entity<SummaryDatum>(entity =>
        {
            entity.HasKey(e => e.SummaryDataId);

            entity.Property(e => e.SummaryDataId).HasColumnName("summaryDataId");
            entity.Property(e => e.SumaryData)
                .IsUnicode(false)
                .HasColumnName("sumaryData");
            entity.Property(e => e.Title)
                .IsUnicode(false)
                .HasColumnName("title");
        });

        modelBuilder.Entity<TypeTraining>(entity =>
        {
            entity.ToTable("TypeTraining");

            entity.Property(e => e.TypeTrainingId).HasColumnName("typeTrainingId");
            entity.Property(e => e.TrainingType)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("trainingType");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
