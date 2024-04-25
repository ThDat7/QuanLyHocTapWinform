using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.Extensions.DependencyInjection;

namespace DTO_QLHT
{
    public partial class student_managementContext : DbContext
    {
        public DbSet<User> Users { get; set; }
        public DbSet<Teacher> Teachers { get; set; }
        public DbSet<Student> Students { get; set; }
        public DbSet<Teach> Teaches { get; set; }
        public DbSet<Subject> Subjects { get; set; }
        public DbSet<SubjectGrade> SubjectGrades { get; set; }
        public DbSet<SubjectGradeSemester> SubjectGradeSemesters { get; set; }
        public DbSet<NormalGrade> NormalGrades { get; set; }

        public DbSet<FinalGrade> FinalGrades { get; set; }

        public DbSet<Classroom> Classrooms { get; set; }

    public student_managementContext()
        {
        }

        public student_managementContext(DbContextOptions<student_managementContext> options)
            : base(options)
        {
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("Server=Vostro-3400\\SQLEXPRESS;Database=student_management;Trusted_Connection=True;TrustServerCertificate=True;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Classroom>()
            .Property(c => c.IsLock)
            .HasDefaultValue(false);
            OnModelCreatingPartial(modelBuilder);

            modelBuilder.Entity<Teach>()
                .HasOne(t => t.Teacher)
                .WithMany(t => t.Teaches)
                .OnDelete(DeleteBehavior.Restrict);
        }

        //protected override void OnModelCreating(ModelBuilder modelBuilder)
        //{
        //    modelBuilder.Entity<Teach>()
        //        .HasOne(t => t.Teacher)
        //        .WithMany(t => t.Teaches)
        //        .OnDelete(DeleteBehavior.Restrict);

        ////     Thiết lập các ràng buộc ngoại khác tại đây

        //    base.OnModelCreating(modelBuilder);
        //}

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
