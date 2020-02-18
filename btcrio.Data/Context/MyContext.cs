using btc.Data.Mapping;
using btc.Domain.Entiity;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace btc.Data.Context
{
    public class MyContext : DbContext
    {
        public DbSet<RevendedorEntity> Revendedores { get; set; }

        public MyContext(DbContextOptions<MyContext> options) : base(options) { }

        protected override void OnModelCreating (ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<RevendedorEntity>(new RevendedorMap().Configure);
        }

    }
}
