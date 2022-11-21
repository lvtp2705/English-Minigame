using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace Minigame.Models
{
    public partial class RankDB : DbContext
    {
        public RankDB()
            : base("name=RankDB")
        {
        }

        public virtual DbSet<rank> ranks { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
        }
    }
}
