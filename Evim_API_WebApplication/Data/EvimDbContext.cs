using Evim_API_WebApplication.Entities;
using Evim_API_WebApplication.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace Evim_API_WebApplication.Data
{
    public class EvimDbContext : IdentityDbContext<AppUser, AppRole, int>
    {
        public EvimDbContext(DbContextOptions<EvimDbContext> options) : base(options) 
        { }

        public DbSet<Country> Countries { get; set; }
        public DbSet<City> Cities { get; set; }
        public DbSet<Nbhood> Nbhoods { get; set; }
        public DbSet<Building> Buildings { get; set; }
        public DbSet<Situation> Situations { get; set; }
        public DbSet<Variety> Varieties { get; set; }

        public DbSet<Advertisement> Advertisements { get; set; }

        public DbSet<Picture> Pictures { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Country>().HasData
                (new Country { CountryId = 1, CountryName = "Türkiye" },
                 new Country { CountryId = 2, CountryName = "Canada" });

            modelBuilder.Entity<City>().HasData(
                new City { CityId = 1, CityName = "İstanbul", CountryId = 1 },
                new City { CityId = 2, CityName = "Ankara", CountryId = 1 },
                new City { CityId = 3, CityName = "Toronto", CountryId = 2 },
                new City { CityId = 4, CityName = "Montreal", CountryId = 2 }
            );

            modelBuilder.Entity<Nbhood>().HasData(
               new Nbhood { NbhoodId = 1, NbhoodName = "Taksim", CityId = 1 },
               new Nbhood { NbhoodId = 2, NbhoodName = "Kızılay", CityId = 2 },
               new Nbhood { NbhoodId = 3, NbhoodName = "Downtown Toronto", CityId = 3 },
               new Nbhood { NbhoodId = 4, NbhoodName = "Old Montreal", CityId = 4 }

           );

            modelBuilder.Entity<Building>().HasData(
            new Building { BuildingId = 1, BuildingName = "Galata Building", NbhoodId = 1 },
            new Building { BuildingId = 2, BuildingName = "Atalar Konutları", NbhoodId = 2 },
            new Building { BuildingId = 3, BuildingName = "Canada Tower", NbhoodId = 3 },
            new Building { BuildingId = 4, BuildingName = "Canada Montreal Tower", NbhoodId = 4 }
            );

            modelBuilder.Entity<Variety>().HasData(
            new Variety { VarietyId = 1, VarietyName = "House", SituationId = 1 },
            new Variety { VarietyId = 2, VarietyName = "Store", SituationId = 2 }
            );

            modelBuilder.Entity<Advertisement>().HasData(
            new Advertisement
            {
                AdvertisementId = 1,
                SituationId = 1,
                VarietyId = 1,
                Loan = true,
                Description = "Galata Apartments",
                NbhoodId = 1,
                BuildingId = 1,
                CityId = 1,
                Address = "Galata Apartmens No:1 Taksim İstanbul",
                Bathrooms = 2,
                Rooms = 5,
                PhoneNumber = "+905555554444",
                Price = 20.000,
                UserName = "John Doe"
            },
            new Advertisement
            {
                AdvertisementId = 2,
                SituationId = 2,
                VarietyId = 2,
                Loan = true,
                Description = "Canada Buildings",
                NbhoodId = 2,
                BuildingId = 2,
                CityId = 2,
                Address = "Canada Buildings Field No:4-2K Downtown Toronto City",
                Bathrooms = 3,
                Rooms = 4,
                PhoneNumber = "+1101200920020",
                Price = 15.000,
                UserName = "Susan Monroe"
            }
             );


             modelBuilder.Entity<Picture>().HasData(
             new Picture { PictureId=1, PictureName="Galata Apartments", AdvertisementId=1},
             new Picture { PictureId=2, PictureName="Canada Buildings", AdvertisementId=2}
            );



        }

    }
}
