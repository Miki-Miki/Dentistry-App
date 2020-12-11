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
        public DbSet<Lijekovi> Lijekovi { get; set; }
    }
}
