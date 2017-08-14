namespace PrototypeBHost
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class HandyMobileDatabase : DbContext
    {
        public HandyMobileDatabase()
            : base("name=HandyMobileDatabase")
        {
        }

        public virtual DbSet<Patient> Patient { get; set; }
        public virtual DbSet<Test> Test { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Patient>()
                .Property(e => e.pat_nom)
                .IsUnicode(false);

            modelBuilder.Entity<Patient>()
                .Property(e => e.pat_prenom)
                .IsUnicode(false);

            modelBuilder.Entity<Patient>()
                .Property(e => e.pat_adresse)
                .IsUnicode(false);

            modelBuilder.Entity<Patient>()
                .Property(e => e.pat_ville)
                .IsUnicode(false);

            modelBuilder.Entity<Patient>()
                .Property(e => e.pat_pays)
                .IsUnicode(false);

            modelBuilder.Entity<Patient>()
                .Property(e => e.pat_Natel)
                .IsUnicode(false);

            modelBuilder.Entity<Patient>()
                .Property(e => e.pat_Teleèhone)
                .IsUnicode(false);

            modelBuilder.Entity<Patient>()
                .Property(e => e.pat_nomMere)
                .IsUnicode(false);

            modelBuilder.Entity<Patient>()
                .Property(e => e.pat_prenomMere)
                .IsUnicode(false);

            modelBuilder.Entity<Patient>()
                .Property(e => e.pat_nomPere)
                .IsUnicode(false);

            modelBuilder.Entity<Patient>()
                .Property(e => e.pat_prenomPere)
                .IsUnicode(false);

            modelBuilder.Entity<Test>()
                .Property(e => e.tes_test)
                .IsUnicode(false);
        }
    }
}
