using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using NorthwindWinFormsApp.Configuration;

namespace NorthwindWinFormsApp.Models;

public partial class NorthwindContext : DbContext
{
    public NorthwindContext()
    {
    }

    public NorthwindContext(DbContextOptions<NorthwindContext> options)
        : base(options)
    {
    }
   
    public virtual DbSet<Customer> Customers { get; set; }
   
    public DbSet<CombinedInvoicesAndCustomers> CombinedInvoicesAndCustomers { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        // Use the connection string from the configuration
        AppConfig config = ConfigurationManager.LoadConfiguration();
        optionsBuilder.UseSqlServer(config.ConnectionStrings.MyConnectionString);

        // Enable logging
        optionsBuilder.LogTo(Console.Write);
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {

        modelBuilder.Entity<Customer>(entity =>
        {
            entity.HasIndex(e => e.City, "City");

            entity.HasIndex(e => e.CompanyName, "CompanyName");

            entity.HasIndex(e => e.PostalCode, "PostalCode");

            entity.HasIndex(e => e.Region, "Region");

            entity.Property(e => e.CustomerId)
                .HasMaxLength(5)
                .IsFixedLength()
                .HasColumnName("CustomerID");
            entity.Property(e => e.Address).HasMaxLength(60);
            entity.Property(e => e.City).HasMaxLength(15);
            entity.Property(e => e.CompanyName).HasMaxLength(40);
            entity.Property(e => e.ContactName).HasMaxLength(30);
            entity.Property(e => e.ContactTitle).HasMaxLength(30);
            entity.Property(e => e.Country).HasMaxLength(15);
            entity.Property(e => e.Fax).HasMaxLength(24);
            entity.Property(e => e.Phone).HasMaxLength(24);
            entity.Property(e => e.PostalCode).HasMaxLength(10);
            entity.Property(e => e.Region).HasMaxLength(15);


        });
         
        // Configure CombinedInvoicesAndCustomers as a keyless entity type
        modelBuilder.Entity<CombinedInvoicesAndCustomers>().HasNoKey();

    OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);

    public IEnumerable<Customer> GetAllCustomer()
    {
        var allCustomerList = this.Set<Customer>()
            .FromSqlRaw("EXEC GetCustomers")
            .ToList();

        return allCustomerList;
    }
}
