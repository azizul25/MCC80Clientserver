
using API.Models;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;

public class BookingDbContext : DbContext
{
	public BookingDbContext(DbContextOptions<BookingDbContext>options) : base(options) { }

    public DbSet <Account> Accounts { get; set; }
    public DbSet<AccountRole> AccountRoles { get; set; }
    public DbSet<Booking> Bokings { get; set; }
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
    }
}