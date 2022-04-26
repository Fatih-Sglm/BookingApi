using BookingHotelAPI.Domain.Entities.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookingHotelAPI.Domain.Entities
{
    public class Room :BaseEntity
    {
        public string Room_name { get; set; }
        public string Description { get; set; }
        public Room_Type RoomType { get; set; }
        public Hotel Hotel { get; set; }
        public Guid HotelId { get; set; }
        public Guid RoomTypeId { get; set; }
    }
}
