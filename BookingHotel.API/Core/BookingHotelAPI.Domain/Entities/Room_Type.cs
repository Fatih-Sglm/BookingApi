using BookingHotelAPI.Domain.Entities.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookingHotelAPI.Domain.Entities
{
    public class Room_Type :BaseEntity
    {
        public string Typename { get; set; }
        public ICollection<Room> Rooms { get; set; }
    }
}
