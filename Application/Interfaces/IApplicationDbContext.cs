using LeadsManagement.Entities;
using Microsoft.EntityFrameworkCore;

namespace LeadsManagement.Application.Interfaces;

public interface IApplicationDbContext
{
    DbSet<Contact> Contacts { get; set; }
    DbSet<Category> Categories { get; set; }

    Task<int> SaveChangesAsync(CancellationToken cancellationToken);
}