using Common.Entities;
using Common.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Presentation.ViewModels
{
    public class RoomViewModel
    {
        public string RoomNumber { get; set; }
        public RoomType RoomType { get; set; }
        public BedType BedType { get; set; }
        public decimal PricePerNight { get; set; }
        public bool IsBooked { get; set; }

        public List<Room> Rooms = new();
    }
}
