using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace MyrnaEF1
{
    public partial class Model1 : DbContext
    {
        public Model1()
            : base("name=Model1")
        {
        }

        public virtual DbSet<Employee> Employees { get; set; }
        public virtual DbSet<EmployeeAssignment> EmployeeAssignments { get; set; }
        public virtual DbSet<EmployeeRole> EmployeeRoles { get; set; }
        public virtual DbSet<Screening> Screenings { get; set; }
        public virtual DbSet<Show> Shows { get; set; }
        public virtual DbSet<Ticket> Tickets { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Employee>()
                .Property(e => e.FirstName)
                .IsUnicode(false);

            modelBuilder.Entity<Employee>()
                .Property(e => e.LastName)
                .IsUnicode(false);

            modelBuilder.Entity<Employee>()
                .Property(e => e.Email)
                .IsUnicode(false);

            modelBuilder.Entity<Employee>()
                .Property(e => e.Phone)
                .IsUnicode(false);

            modelBuilder.Entity<Employee>()
                .Property(e => e.Street)
                .IsUnicode(false);

            modelBuilder.Entity<Employee>()
                .Property(e => e.City)
                .IsUnicode(false);

            modelBuilder.Entity<Employee>()
                .Property(e => e.State)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Employee>()
                .Property(e => e.Zipcode)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Employee>()
                .HasMany(e => e.EmployeeAssignments)
                .WithRequired(e => e.Employee)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<EmployeeRole>()
                .Property(e => e.RoleName)
                .IsUnicode(false);

            modelBuilder.Entity<EmployeeRole>()
                .HasMany(e => e.EmployeeAssignments)
                .WithRequired(e => e.EmployeeRole)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Screening>()
                .Property(e => e.Theater)
                .IsUnicode(false);

            modelBuilder.Entity<Screening>()
                .HasMany(e => e.EmployeeAssignments)
                .WithRequired(e => e.Screening)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Screening>()
                .HasMany(e => e.Tickets)
                .WithRequired(e => e.Screening)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Show>()
                .Property(e => e.Title)
                .IsUnicode(false);

            modelBuilder.Entity<Show>()
                .Property(e => e.TypeOfShow)
                .IsUnicode(false);

            modelBuilder.Entity<Show>()
                .Property(e => e.Price)
                .HasPrecision(10, 2);

            modelBuilder.Entity<Show>()
                .HasMany(e => e.Screenings)
                .WithRequired(e => e.Show)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Ticket>()
                .Property(e => e.TicketType)
                .IsUnicode(false);

            modelBuilder.Entity<Ticket>()
                .Property(e => e.PatronName)
                .IsUnicode(false);

            modelBuilder.Entity<Ticket>()
                .Property(e => e.PaymentType)
                .IsUnicode(false);
        }
    }
}
