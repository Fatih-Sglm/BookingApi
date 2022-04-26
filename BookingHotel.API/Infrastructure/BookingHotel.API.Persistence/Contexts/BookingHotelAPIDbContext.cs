using BookingHotelAPI.Domain.Entities;
using BookingHotelAPI.Domain.Entities.Common;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookingHotel.API.Persistence.Contexts
{
    public class BookingHotelAPIDbContext : DbContext
    {
        public BookingHotelAPIDbContext(DbContextOptions options) : base(options)
        { }
        public DbSet<Hotel> Hotels { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Room_Type> Room_Types { get; set; }
        public DbSet<Room> Rooms { get; set; }

        public override async Task<int> SaveChangesAsync(CancellationToken cancellationToken = default)
        {
            var datas = ChangeTracker.Entries<BaseEntity>();
                foreach (var item in datas)
            {
                _ = item.State switch
                {
                    EntityState.Added => item.Entity.CreatedAt = DateTime.UtcNow,
                    EntityState.Modified => item.Entity.UpdadeAt = DateTime.UtcNow,
                };

            }
            return await base.SaveChangesAsync(cancellationToken);
        }
    }
}
