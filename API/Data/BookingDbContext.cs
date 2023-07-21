
using API.Models;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;

public class BookingDbContext : DbContext
{
	public BookingDbContext(DbContextOptions<BookingDbContext>options) : base(options) { }

    public DbSet <Account> Accounts { get; set; }
    public DbSet<AccountRole> AccountRoles { get; set; }
    public DbSet<Booking> Bookings { get; set; }
    public DbSet<Education> Educations { get; set; }
    public DbSet<Employee> Employeeds { get; set; }
    public DbSet<Role> Roles { get; set; }
    public DbSet<Room> Rooms { get; set; }
    public DbSet<University> Universities { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);
        modelBuilder.Entity<Employee>()
            .HasIndex(e => new
            {
                e.Nik,
                e.Email,
                e.PhoneNumber
            }).IsUnique();

        //many education with many universities
        modelBuilder.Entity<Education>()
            .HasOne(e => e.University)
            .WithMany(u => u.Educations)
            .HasForeignKey(u => u.UniversityGuid);

        //
        modelBuilder.Entity<Education>()
            .HasOne(e => e.Employees)
            .WithOne(em => em.Educations)
            .HasForeignKey<Education>(em => em.Guid);


        //many education with one universities
        modelBuilder.Entity<Employee>()
            .HasMany(e => e.Bookings)
            .WithOne(b => b.Employees)
            .HasForeignKey(b => b.EmployeeGuid);



        //
        modelBuilder.Entity<Account>()
            .HasOne(a => a.Employees)
            .WithOne(e => e.Accounts)
            .HasForeignKey<Account>(a => a.Guid);
        //
        modelBuilder.Entity<Room>()
            .HasMany(r => r.Bookings)
            .WithOne(b => b.Rooms)
            .HasForeignKey(b => b.RoomGuid);

        //
        modelBuilder.Entity<Account>()
            .HasMany(a => a.AccountRoles)
            .WithOne(ar => ar.Accounts)
            .HasForeignKey(ar => ar.AccountGuid);
        //
        modelBuilder.Entity<Role>()
            .HasMany(r => r.AccountRoles)
            .WithOne(ar => ar.Roles)
            .HasForeignKey(ar => ar.RoleGuid);

    }



}