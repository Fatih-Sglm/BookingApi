using BookingHotelAPI.Domain.Entities.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookingHotelAPI.Domain.Entities
{
    public class Hotel :BaseEntity
    {
        public string HotelsName { get; set; }
        public string Description { get; set; }
        public Category Category { get; set; }
        public ICollection<Room> Rooms { get; set; }
        public Guid CategoryId { get; set; }
    }
}
