using System;
using System.IO;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.Extensions.Configuration;
using BusinessObject;


namespace DataAccessObject
{
    public partial class FeedbackFacilitiesDBContext : DbContext
    {
        public FeedbackFacilitiesDBContext()
        {
        }

        public FeedbackFacilitiesDBContext(DbContextOptions<FeedbackFacilitiesDBContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Device> Devices { get; set; }
        public virtual DbSet<DeviceType> DeviceTypes { get; set; }
        public virtual DbSet<Feedback> Feedbacks { get; set; }
        public virtual DbSet<Floor> Floors { get; set; }
        public virtual DbSet<MemberAccount> MemberAccounts { get; set; }
        public virtual DbSet<Room> Rooms { get; set; }
        public virtual DbSet<TaskFb> TaskFbs { get; set; }
        public virtual DbSet<Staff> Staffs { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("Server=ADMIN-PC\\KHOADDD;Database= FeedbackFacilitiesDB; Uid=sa; Pwd=12345");
                optionsBuilder.UseSqlServer(GetConnectionString());
            }
        }

        private string GetConnectionString()
        {
            IConfiguration configuration = new ConfigurationBuilder()
                    .SetBasePath(Directory.GetCurrentDirectory())
                    .AddJsonFile("appsettings.json", true, true).Build();
            return configuration["ConnectionStrings:DefaultDB"];
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("Relational:Collation", "SQL_Latin1_General_CP1_CI_AS");

            modelBuilder.Entity<Device>(entity =>
            {
                entity.ToTable("Device");

                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.HasOne(d => d.DeviceType)
                    .WithMany(p => p.Devices)
                    .HasForeignKey(d => d.DeviceTypeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Device_DeviceType");

                entity.HasOne(d => d.Room)
                    .WithMany(p => p.Devices)
                    .HasForeignKey(d => d.RoomId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Device_Room");
            });

            modelBuilder.Entity<DeviceType>(entity =>
            {
                entity.ToTable("DeviceType");

                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.DeviceName)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.Type)
                    .IsRequired()
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<Feedback>(entity =>
            {
                entity.ToTable("Feedback");

                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.Day).HasColumnType("date");

                entity.Property(e => e.Description)
                    .IsRequired()
                    .HasMaxLength(150);

                entity.Property(e => e.Quantity).HasDefaultValueSql("((1))");

                entity.HasOne(d => d.Device)
                    .WithMany(p => p.Feedbacks)
                    .HasForeignKey(d => d.DeviceId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Feedback_Device");

                entity.HasOne(d => d.SenderNavigation)
                    .WithMany(p => p.Feedbacks)
                    .HasForeignKey(d => d.Sender)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Feedback_MemberAccount");
            });

            modelBuilder.Entity<Floor>(entity =>
            {
                entity.ToTable("Floor");

                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.FloorName)
                    .IsRequired()
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<MemberAccount>(entity =>
            {
                entity.ToTable("MemberAccount");

                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.Email)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.Password)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.Username)
                    .IsRequired()
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<Room>(entity =>
            {
                entity.ToTable("Room");

                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.HasOne(d => d.Floor)
                    .WithMany(p => p.Rooms)
                    .HasForeignKey(d => d.FloorId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Room_Floor");
            });

            modelBuilder.Entity<TaskFb>(entity =>
            {
                entity.ToTable("TaskFB");

                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.HasOne(d => d.Feedback)
                    .WithMany(p => p.TaskFbs)
                    .HasForeignKey(d => d.FeedbackId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Task_Feedback");

                entity.HasOne(d => d.Staff)
                    .WithMany(p => p.TaskFbs)
                    .HasForeignKey(d => d.StaffId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Task_Staff");
            });

            modelBuilder.Entity<Staff>(entity =>
            {
                entity.ToTable("Staff");

                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.Email)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.Password)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.Username)
                    .IsRequired()
                    .HasMaxLength(50);
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
