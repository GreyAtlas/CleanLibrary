using CleanLibrary.Domain.Common;
using CleanLibrary.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace CleanLibrary.Infrastructure.Data
{
    public class LibraryDataContext : DbContext
    {
        public LibraryDataContext(DbContextOptions<LibraryDataContext> options)
        : base(options) { }

        public DbSet<Book> Books { get; set; }
        public DbSet<Reservation> Reservations { get; set; }

    }
}
