using MedicoDent.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace MedicoDent.Infrastructure.Persistence
{
    public partial class AppDbContext : DbContext
    {

        public DbSet<Patient> Patients => Set<Patient>();
        public DbSet<PatientGroup> PatientGroups => Set<PatientGroup>();
        public DbSet<PatientBasicInfo> PatientBasicInfos => Set<PatientBasicInfo>();
        public DbSet<PatientContact> PatientContacts => Set<PatientContact>();
        public DbSet<Allergie> Allergies => Set<Allergie>();
        public DbSet<Doctor> Doctors => Set<Doctor>();
        public DbSet<MedicoService> Services => Set<MedicoService>();
        public DbSet<PatientAllergies> PatientAllergies => Set<PatientAllergies>();
        public DbSet<PatientGroupMembership> PatientsGroups => Set<PatientGroupMembership>();
        public DbSet<PatientGroupTemplate> PatientGroupTemplates => Set<PatientGroupTemplate>();
        public DbSet<Treatment> Treatments => Set<Treatment>();
        public DbSet<TreatmentStatus> TreatmentStatuses => Set<TreatmentStatus>();
        public DbSet<User> Users => Set<User>();


        public AppDbContext(DbContextOptions<AppDbContext> options)
            : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<PatientGroupMembership>(entity =>
            {
                entity.ToTable("PatientPatientGroups");

                entity.HasKey(x => new { x.PatientId, x.GroupId });

                entity.HasOne(x => x.Patient)
                      .WithMany(p => p.PatientGroupsMembership)
                      .HasForeignKey(x => x.PatientId);

                entity.HasOne(x => x.PatientGroup)
                      .WithMany(g => g.PatientGroupsMembership)
                      .HasForeignKey(x => x.GroupId);
            });

            modelBuilder.Entity<PatientAllergies>(entity =>
            {
                entity.ToTable("PatientAllergies");

                entity.HasKey(x => new { x.PatientId, x.AllergieId });

                entity.HasOne(x => x.Patient)
                    .WithMany(p => p.PatientAllergies)
                    .HasForeignKey(x => x.PatientId)
                    .OnDelete(DeleteBehavior.Cascade);

                entity.HasOne(x => x.Allergie)
                    .WithMany(a => a.PatientAllergies)
                    .HasForeignKey(x => x.AllergieId)
                    .OnDelete(DeleteBehavior.Cascade);
            });

            modelBuilder.Entity<Patient>().HasQueryFilter(p => !p.IsDeleted);
            modelBuilder.Entity<PatientAllergies>().HasQueryFilter(pa => !pa.Patient!.IsDeleted);
            modelBuilder.Entity<PatientGroupMembership>().HasQueryFilter(pg => !pg.Patient!.IsDeleted);
            modelBuilder.Entity<Treatment>().HasQueryFilter(t => !t.Patient!.IsDeleted);
            modelBuilder.Entity<PatientContact>().HasQueryFilter(pc => !pc.Patient!.IsDeleted);
            modelBuilder.Entity<PatientBasicInfo>().HasQueryFilter(pb => !pb.Patient!.IsDeleted);
            
            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
