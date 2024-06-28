using Microsoft.EntityFrameworkCore;
using LeadsManagement.Entities;
using LeadsManagement.Application.Interfaces;
using System.Reflection;

namespace LeadsManagement.Repository;
public class ApplicationDbContext : DbContext, IApplicationDbContext
{
    public ApplicationDbContext()
    {
    }
    public ApplicationDbContext(DbContextOptions options) : base(options)
    {
    }
    public DbSet<Contact> Contacts { get; set; }
    public DbSet<Category> Categories { get; set; }
    protected override void OnConfiguring(DbContextOptionsBuilder options) =>
            options.UseSqlServer("Server=localhost,1433;Database=SeeSharpBlog;User ID=sa;Password=P@ssw0rd;TrustServerCertificate=True");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
        base.OnModelCreating(modelBuilder);
        List<Category> categories = new List<Category>
        {
            new Category {
                Id = 1,
                Name = "Photographer"
            },
            new Category {
                Id = 2,
                Name = "Attorney"
            },
            new Category {
                Id = 3,
                Name = "Medic"
            },
            new Category {
                Id = 4,
                Name = "Mechanic"
            }
        };
        List<Contact> contacts = new List<Contact>
        {
            new Contact {
                Id = 1,
                Name = "Peter Parker",
                CreatedDate =  DateTime.Parse("2024-02-22T08:14:24Z"),
                Suburb = "Forest Hills",
                CategoryId = 1,
                Description = "Neighborhood Friend",
                Price = 600,
                Phone = "890258422",
                Email ="fozemwet@nauri.ml",
            },
            new Contact {
                Id = 2,
                Name = "Matt Murdock",
                CreatedDate =  DateTime.Parse("2021-01-22T17:14:24Z"),
                Suburb = "Hell's Kitchen",
                CategoryId = 2,
                Description = "Avocado at Law",
                Price = 200,
                Phone = "880649211",
                Email ="kuz@iwocir.tc",

            },
            new Contact {
                Id = 3,
                Name = "Stephen Strange",
                CreatedDate =  DateTime.Parse("2024-06-22T12:14:24Z"),
                Suburb = "Greenwich Village",
                CategoryId = 3,
                Description = "The mightiest magician in the cosmos",
                Price = 600,
                Phone = "133486432",
                Email ="fozemwet@nauri.ml",                
            },
            new Contact {
                Id = 4,
                Name = "Tony Stark",
                CreatedDate =  DateTime.Parse("2024-02-22T18:14:24Z"),
                Suburb = "Midtown Manhattan",
                CategoryId = 4,
                Description = "Genius, billionaire, playboy, philanthropist",
                Price = 700.32M,
                Phone = "433786225",
                Email ="zohusnu@rog.so",     
            },
        };
        modelBuilder.Entity<Category>().HasData(
            categories
        );
        modelBuilder.Entity<Contact>().HasData(
            contacts
        );
    }


}
