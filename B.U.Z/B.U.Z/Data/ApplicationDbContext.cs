using System;
using System.Collections.Generic;
using System.Text;
using B.U.Z.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace B.U.Z.Data
{
    public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
    {
        public ApplicationDbContext()
        {
        }

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"	Server=app.fit.ba, 1431;
                                        	Database=p2049;
                                            Trusted_Connection=False;
                                            User ID=p2049_user_1;
                                            Password=SamirMumic3#;
                                            MultipleActiveResultSets=true;    ");
        }

        //protected override void OnModelCreating(ModelBuilder modelBuilder)
        //{
        //    base.OnModelCreating(modelBuilder);
        //    //modelBuilder.Entity<ApplicationUser>().ToTable("ApplicationUser");
        //}

        public DbSet<Lijekovi> Lijekovi { get; set; }
        public DbSet<LijekNaSesiji> LijekNaSesiji { get; set; }
        public DbSet<Recepti> Recepti { get; set; }
        public DbSet<Dijagnoze> Dijagnoze { get; set; }
        
        public DbSet<Grad> Grad { get; set; }
        public DbSet<Spol> Spol { get; set; }
        public DbSet<Kanton> Kanton { get; set; }
        public DbSet<Stomatolog> Stomatolozi { get; set; }

        public DbSet<Pacijent> Pacijenti { get; set; }
        public DbSet<Asistent> Asistenti { get; set; }

        public DbSet<Termini> Termini { get; set; }
        public DbSet<ApplicationUser> ApplicationUsers { get; set; }

        public DbSet<CTNalaz> CTNalaz { get; set; }
        public DbSet<DentalnaPomagala> DentalnaPomagala { get; set; }
        public DbSet<DentalnoPomagaloNaSesiji> DentalnoPomagaloNaSesiji { get; set; }
        public DbSet<DijagnozaNaSesiji> DijagnozaNaSesiji { get; set; }
        public DbSet<Sesija> Sesija { get; set; }
        public DbSet<Racun> Racun { get; set; }
        public DbSet<TerapijaNaSesiji> TerapijaNaSesiji { get; set; }
        public DbSet<Terapije> Terapije { get; set; }
        public DbSet<Usluga> Usluga { get; set; }
        public DbSet<ZakazanaUsluga> ZakazanaUsluga { get; set; }
    }
}
