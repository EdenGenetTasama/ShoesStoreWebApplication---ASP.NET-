using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace ShoesStoreWebApplication.Models
{
    public partial class ShoesContext : DbContext
    {
        public ShoesContext()
            : base("name=ShoesContext")
        {
        }

        public virtual DbSet<OutShoes> OutShoes{get; set;}
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
        }
    }
}
