// <auto-generated />
using System;
using B.U.Z.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace B.U.Z.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20210116172458_dodanaDijagnoza")]
    partial class dodanaDijagnoza
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.10")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("B.U.Z.Models.ApplicationUser", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("AccessFailedCount")
                        .HasColumnType("int");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Discriminator")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(256)")
                        .HasMaxLength(256);

                    b.Property<bool>("EmailConfirmed")
                        .HasColumnType("bit");

                    b.Property<string>("FirstName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("GodinaRodjenja")
                        .HasColumnType("datetime2");

                    b.Property<int>("GradId")
                        .HasColumnType("int");

                    b.Property<string>("LastName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("LockoutEnabled")
                        .HasColumnType("bit");

                    b.Property<DateTimeOffset?>("LockoutEnd")
                        .HasColumnType("datetimeoffset");

                    b.Property<string>("NormalizedEmail")
                        .HasColumnType("nvarchar(256)")
                        .HasMaxLength(256);

                    b.Property<string>("NormalizedUserName")
                        .HasColumnType("nvarchar(256)")
                        .HasMaxLength(256);

                    b.Property<string>("PasswordHash")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("PhoneNumberConfirmed")
                        .HasColumnType("bit");

                    b.Property<string>("SecurityStamp")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("SpolId")
                        .HasColumnType("int");

                    b.Property<bool>("TwoFactorEnabled")
                        .HasColumnType("bit");

                    b.Property<string>("UserName")
                        .HasColumnType("nvarchar(256)")
                        .HasMaxLength(256);

                    b.HasKey("Id");

                    b.HasIndex("GradId");

                    b.HasIndex("NormalizedEmail")
                        .HasName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasName("UserNameIndex")
                        .HasFilter("[NormalizedUserName] IS NOT NULL");

                    b.HasIndex("SpolId");

                    b.ToTable("AspNetUsers");

                    b.HasDiscriminator<string>("Discriminator").HasValue("ApplicationUser");
                });

            modelBuilder.Entity("B.U.Z.Models.CTNalaz", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Nalaz")
                        .HasColumnType("nvarchar(max)");

                    b.Property<byte[]>("Snimak")
                        .HasColumnType("varbinary(max)");

                    b.HasKey("Id");

                    b.ToTable("CTNalaz");
                });

            modelBuilder.Entity("B.U.Z.Models.DentalnaPomagala", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Naziv")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Vrsta")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("DentalnaPomagala");
                });

            modelBuilder.Entity("B.U.Z.Models.DentalnoPomagaloNaSesiji", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("DatumIzdavanja")
                        .HasColumnType("datetime2");

                    b.Property<int>("DentalnoPomgaloId")
                        .HasColumnType("int");

                    b.Property<int>("SesijaId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("DentalnoPomgaloId");

                    b.HasIndex("SesijaId");

                    b.ToTable("DentalnoPomagaloNaSesiji");
                });

            modelBuilder.Entity("B.U.Z.Models.DijagnozaNaSesiji", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("DijagnozaId")
                        .HasColumnType("int");

                    b.Property<string>("Opis")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("SesijaId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("DijagnozaId");

                    b.HasIndex("SesijaId");

                    b.ToTable("DijagnozaNaSesiji");
                });

            modelBuilder.Entity("B.U.Z.Models.Dijagnoze", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Naziv")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Opis")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Preporuka")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Dijagnoze");
                });

            modelBuilder.Entity("B.U.Z.Models.Grad", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("KantonId")
                        .HasColumnType("int");

                    b.Property<string>("Naziv")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("KantonId");

                    b.ToTable("Grad");
                });

            modelBuilder.Entity("B.U.Z.Models.Kanton", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Naziv")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Kanton");
                });

            modelBuilder.Entity("B.U.Z.Models.Lijekovi", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Naziv")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Opis")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Lijekovi");
                });

            modelBuilder.Entity("B.U.Z.Models.Racun", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("Datum")
                        .HasColumnType("datetime2");

                    b.Property<string>("Napomena")
                        .HasColumnType("nvarchar(max)");

                    b.Property<double>("OsnovnaCijena")
                        .HasColumnType("float");

                    b.Property<double>("UkupnaCijena")
                        .HasColumnType("float");

                    b.Property<double>("stopaPDV")
                        .HasColumnType("float");

                    b.HasKey("Id");

                    b.ToTable("Racun");
                });

            modelBuilder.Entity("B.U.Z.Models.Recepti", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Naziv")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Opis")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Preporuka")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Recepti");
                });

            modelBuilder.Entity("B.U.Z.Models.Sesija", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("CTNalazId")
                        .HasColumnType("int");

                    b.Property<int?>("DentalnoPomagaloId")
                        .HasColumnType("int");

                    b.Property<int?>("DijagnozaId")
                        .HasColumnType("int");

                    b.Property<int?>("LijekId")
                        .HasColumnType("int");

                    b.Property<string>("StomatologId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<int?>("TerminId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("CTNalazId");

                    b.HasIndex("DentalnoPomagaloId");

                    b.HasIndex("DijagnozaId");

                    b.HasIndex("LijekId");

                    b.HasIndex("StomatologId");

                    b.HasIndex("TerminId");

                    b.ToTable("Sesija");
                });

            modelBuilder.Entity("B.U.Z.Models.Spol", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Naziv")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Spol");
                });

            modelBuilder.Entity("B.U.Z.Models.TerapijaNaSesiji", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Instrukcije")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("SesijaId")
                        .HasColumnType("int");

                    b.Property<int>("TerapijaId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("SesijaId");

                    b.HasIndex("TerapijaId");

                    b.ToTable("TerapijaNaSesiji");
                });

            modelBuilder.Entity("B.U.Z.Models.Terapije", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Naziv")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Opis")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Terapije");
                });

            modelBuilder.Entity("B.U.Z.Models.Termini", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("AsistentId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("PacijentId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<DateTime>("TerminEnd")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("TerminStart")
                        .HasColumnType("datetime2");

                    b.Property<double>("basePrice")
                        .HasColumnType("float");

                    b.HasKey("Id");

                    b.HasIndex("AsistentId");

                    b.HasIndex("PacijentId");

                    b.ToTable("Termini");
                });

            modelBuilder.Entity("B.U.Z.Models.Usluga", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<double>("Cijena")
                        .HasColumnType("float");

                    b.Property<string>("Naziv")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Opis")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Usluga");
                });

            modelBuilder.Entity("B.U.Z.Models.ZakazanaUsluga", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Opis")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("TerminId")
                        .HasColumnType("int");

                    b.Property<int>("UslugaId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("TerminId");

                    b.HasIndex("UslugaId");

                    b.ToTable("ZakazanaUsluga");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRole", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(256)")
                        .HasMaxLength(256);

                    b.Property<string>("NormalizedName")
                        .HasColumnType("nvarchar(256)")
                        .HasMaxLength(256);

                    b.HasKey("Id");

                    b.HasIndex("NormalizedName")
                        .IsUnique()
                        .HasName("RoleNameIndex")
                        .HasFilter("[NormalizedName] IS NOT NULL");

                    b.ToTable("AspNetRoles");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("RoleId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetRoleClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.Property<string>("LoginProvider")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ProviderKey")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ProviderDisplayName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserLogins");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("RoleId")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetUserRoles");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("LoginProvider")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Value")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens");
                });

            modelBuilder.Entity("B.U.Z.Models.Asistent", b =>
                {
                    b.HasBaseType("B.U.Z.Models.ApplicationUser");

                    b.Property<string>("Titula")
                        .HasColumnType("nvarchar(max)");

                    b.HasDiscriminator().HasValue("Asistent");
                });

            modelBuilder.Entity("B.U.Z.Models.Pacijent", b =>
                {
                    b.HasBaseType("B.U.Z.Models.ApplicationUser");

                    b.Property<int>("BrojKartona")
                        .HasColumnType("int");

                    b.HasDiscriminator().HasValue("Pacijent");
                });

            modelBuilder.Entity("B.U.Z.Models.Stomatolog", b =>
                {
                    b.HasBaseType("B.U.Z.Models.Asistent");

                    b.Property<string>("Specijalizacija")
                        .HasColumnType("nvarchar(max)");

                    b.HasDiscriminator().HasValue("Stomatolog");
                });

            modelBuilder.Entity("B.U.Z.Models.ApplicationUser", b =>
                {
                    b.HasOne("B.U.Z.Models.Grad", "Grad")
                        .WithMany()
                        .HasForeignKey("GradId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("B.U.Z.Models.Spol", "Spol")
                        .WithMany()
                        .HasForeignKey("SpolId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("B.U.Z.Models.DentalnoPomagaloNaSesiji", b =>
                {
                    b.HasOne("B.U.Z.Models.DentalnaPomagala", "DentalnoPomgalo")
                        .WithMany()
                        .HasForeignKey("DentalnoPomgaloId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("B.U.Z.Models.Sesija", "Sesija")
                        .WithMany()
                        .HasForeignKey("SesijaId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("B.U.Z.Models.DijagnozaNaSesiji", b =>
                {
                    b.HasOne("B.U.Z.Models.Dijagnoze", "Dijagnoza")
                        .WithMany()
                        .HasForeignKey("DijagnozaId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("B.U.Z.Models.Sesija", "Sesija")
                        .WithMany()
                        .HasForeignKey("SesijaId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("B.U.Z.Models.Grad", b =>
                {
                    b.HasOne("B.U.Z.Models.Kanton", "Kanton")
                        .WithMany()
                        .HasForeignKey("KantonId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("B.U.Z.Models.Sesija", b =>
                {
                    b.HasOne("B.U.Z.Models.CTNalaz", "CTNalaz")
                        .WithMany()
                        .HasForeignKey("CTNalazId");

                    b.HasOne("B.U.Z.Models.DentalnaPomagala", "DentalnoPomagalo")
                        .WithMany()
                        .HasForeignKey("DentalnoPomagaloId");

                    b.HasOne("B.U.Z.Models.Dijagnoze", "Dijagnoza")
                        .WithMany()
                        .HasForeignKey("DijagnozaId");

                    b.HasOne("B.U.Z.Models.Lijekovi", "Lijek")
                        .WithMany()
                        .HasForeignKey("LijekId");

                    b.HasOne("B.U.Z.Models.Stomatolog", "Stomatolog")
                        .WithMany()
                        .HasForeignKey("StomatologId");

                    b.HasOne("B.U.Z.Models.Termini", "Termin")
                        .WithMany()
                        .HasForeignKey("TerminId");
                });

            modelBuilder.Entity("B.U.Z.Models.TerapijaNaSesiji", b =>
                {
                    b.HasOne("B.U.Z.Models.Sesija", "Sesija")
                        .WithMany()
                        .HasForeignKey("SesijaId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("B.U.Z.Models.Terapije", "Terapija")
                        .WithMany()
                        .HasForeignKey("TerapijaId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("B.U.Z.Models.Termini", b =>
                {
                    b.HasOne("B.U.Z.Models.Asistent", "Asistent")
                        .WithMany()
                        .HasForeignKey("AsistentId");

                    b.HasOne("B.U.Z.Models.Pacijent", "Pacijent")
                        .WithMany()
                        .HasForeignKey("PacijentId");
                });

            modelBuilder.Entity("B.U.Z.Models.ZakazanaUsluga", b =>
                {
                    b.HasOne("B.U.Z.Models.Termini", "Termin")
                        .WithMany()
                        .HasForeignKey("TerminId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("B.U.Z.Models.Usluga", "Usluga")
                        .WithMany()
                        .HasForeignKey("UslugaId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.HasOne("B.U.Z.Models.ApplicationUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.HasOne("B.U.Z.Models.ApplicationUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("B.U.Z.Models.ApplicationUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.HasOne("B.U.Z.Models.ApplicationUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
