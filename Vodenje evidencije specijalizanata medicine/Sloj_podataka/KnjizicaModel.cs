using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace Sloj_podataka
{
    public partial class KnjizicaModel : DbContext
    {
        public KnjizicaModel()
            : base("name=KnjizicaModel")
        {
        }

        public virtual DbSet<Kompetencije> Kompetencije { get; set; }
        public virtual DbSet<Korisnik> Korisnik { get; set; }
        public virtual DbSet<Mentor> Mentor { get; set; }
        public virtual DbSet<RasporedPrograma> RasporedPrograma { get; set; }
        public virtual DbSet<Specijalizacija> Specijalizacija { get; set; }
        public virtual DbSet<Specijalizant> Specijalizant { get; set; }
        public virtual DbSet<Uloga> Uloga { get; set; }
        public virtual DbSet<Zahvati> Zahvati { get; set; }
        public virtual DbSet<ZavrsetakSpecijalizacije> ZavrsetakSpecijalizacije { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Kompetencije>()
                .Property(e => e.kompetencije1)
                .IsUnicode(false);

            modelBuilder.Entity<Kompetencije>()
                .Property(e => e.potpis_mentor)
                .IsUnicode(false);

            modelBuilder.Entity<Kompetencije>()
                .Property(e => e.potpis_gl_mentor)
                .IsUnicode(false);

            modelBuilder.Entity<Korisnik>()
                .Property(e => e.ime)
                .IsUnicode(false);

            modelBuilder.Entity<Korisnik>()
                .Property(e => e.prezime)
                .IsUnicode(false);

            modelBuilder.Entity<Korisnik>()
                .Property(e => e.email)
                .IsUnicode(false);

            modelBuilder.Entity<Korisnik>()
                .Property(e => e.lozinka)
                .IsUnicode(false);

            modelBuilder.Entity<Korisnik>()
                .HasMany(e => e.Kompetencije)
                .WithRequired(e => e.Korisnik)
                .HasForeignKey(e => e.mentor)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Korisnik>()
                .HasOptional(e => e.Mentor)
                .WithRequired(e => e.Korisnik1);

            modelBuilder.Entity<Korisnik>()
                .HasMany(e => e.RasporedPrograma)
                .WithRequired(e => e.Korisnik)
                .HasForeignKey(e => e.mentor)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Korisnik>()
                .HasMany(e => e.Specijalizacija)
                .WithRequired(e => e.Korisnik)
                .HasForeignKey(e => e.specijalizant)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Korisnik>()
                .HasMany(e => e.Specijalizacija1)
                .WithRequired(e => e.Korisnik1)
                .HasForeignKey(e => e.glavni_mentor)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Korisnik>()
                .HasOptional(e => e.Specijalizant)
                .WithRequired(e => e.Korisnik1);

            modelBuilder.Entity<Korisnik>()
                .HasMany(e => e.Zahvati)
                .WithOptional(e => e.Korisnik)
                .HasForeignKey(e => e.mentor);

            modelBuilder.Entity<Mentor>()
                .Property(e => e.ustanova)
                .IsUnicode(false);

            modelBuilder.Entity<RasporedPrograma>()
                .Property(e => e.naziv_ustanove)
                .IsUnicode(false);

            modelBuilder.Entity<RasporedPrograma>()
                .Property(e => e.naziv_odjela)
                .IsUnicode(false);

            modelBuilder.Entity<RasporedPrograma>()
                .Property(e => e.pravna_fizicka_osoba)
                .IsUnicode(false);

            modelBuilder.Entity<RasporedPrograma>()
                .Property(e => e.ustrojstvena_jedinica)
                .IsUnicode(false);

            modelBuilder.Entity<RasporedPrograma>()
                .Property(e => e.potpis_mentor)
                .IsUnicode(false);

            modelBuilder.Entity<RasporedPrograma>()
                .Property(e => e.potpis_gl_mentor)
                .IsUnicode(false);

            modelBuilder.Entity<Specijalizacija>()
                .Property(e => e.specijalizacija1)
                .IsUnicode(false);

            modelBuilder.Entity<Specijalizacija>()
                .Property(e => e.odobrena_za)
                .IsUnicode(false);

            modelBuilder.Entity<Specijalizacija>()
                .Property(e => e.klasa)
                .IsUnicode(false);

            modelBuilder.Entity<Specijalizacija>()
                .Property(e => e.ubroj)
                .IsUnicode(false);

            modelBuilder.Entity<Specijalizacija>()
                .Property(e => e.potpis_gl_mentora)
                .IsUnicode(false);

            modelBuilder.Entity<Specijalizacija>()
                .HasMany(e => e.Kompetencije)
                .WithRequired(e => e.Specijalizacija1)
                .HasForeignKey(e => e.specijalizacija)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Specijalizacija>()
                .HasMany(e => e.RasporedPrograma)
                .WithRequired(e => e.Specijalizacija1)
                .HasForeignKey(e => e.specijalizacija)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Specijalizacija>()
                .HasMany(e => e.Zahvati)
                .WithRequired(e => e.Specijalizacija1)
                .HasForeignKey(e => e.specijalizacija)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Specijalizacija>()
                .HasMany(e => e.ZavrsetakSpecijalizacije)
                .WithRequired(e => e.Specijalizacija1)
                .HasForeignKey(e => e.specijalizacija)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Uloga>()
                .Property(e => e.uloga1)
                .IsUnicode(false);

            modelBuilder.Entity<Uloga>()
                .HasMany(e => e.Korisnik)
                .WithRequired(e => e.Uloga1)
                .HasForeignKey(e => e.uloga)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Zahvati>()
                .Property(e => e.naziv_zahvata)
                .IsUnicode(false);

            modelBuilder.Entity<Zahvati>()
                .Property(e => e.potpis_mentor)
                .IsUnicode(false);

            modelBuilder.Entity<Zahvati>()
                .Property(e => e.potpis_gl_mentor)
                .IsUnicode(false);

            modelBuilder.Entity<ZavrsetakSpecijalizacije>()
                .Property(e => e.misljenje_gl_mentora)
                .IsUnicode(false);

            modelBuilder.Entity<ZavrsetakSpecijalizacije>()
                .Property(e => e.potpis_gl_mentor)
                .IsUnicode(false);
        }
    }
}
