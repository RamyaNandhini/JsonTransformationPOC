using JsonTransformationPOC.DataAccess.Model;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace JsonTransformationPOC.DataAccess.DBContext
{
    public class BCContext : DbContext
    {
        public BCContext(DbContextOptions<BCContext> options)
            : base(options)
        {
        }
        

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<ItemCategory>(entity =>
            {
                entity.HasKey(e => e.Id);

                entity.ToTable("ItemCategory");
                            
            });

        }

        public virtual DbSet<ItemCategory> ItemCategory { get; set; }
    }
}
