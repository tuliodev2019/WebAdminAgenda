﻿using System.Reflection;
using webAdmin.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace webAdmin.InfraStructure.Data.Context
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        { }

        #region DbSet

        public DbSet<Cliente>? Clientes { get; set; }
        public DbSet<Usuario>? Usuarios { get; set; }

        #endregion DbSet

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
        }

        public override int SaveChanges()
        {
            return base.SaveChanges();
        }
    }
}
