namespace AlphaSupreme.Models
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class SupremeContext : DbContext
    {
        public SupremeContext()
            : base("name=SupremeContext")
        {
        }

        public virtual DbSet<Supreme_CourseMaster> Supreme_CourseMaster { get; set; }
        public virtual DbSet<Supreme_Qualification> Supreme_Qualification { get; set; }
        public virtual DbSet<Supreme_SkillMaster> Supreme_SkillMaster { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Supreme_CourseMaster>()
                .Property(e => e.CourseName)
                .IsUnicode(false);

            modelBuilder.Entity<Supreme_Qualification>()
                .Property(e => e.QualificationName)
                .IsUnicode(false);

            modelBuilder.Entity<Supreme_SkillMaster>()
                .Property(e => e.SkillName)
                .IsUnicode(false);
        }
    }
}
