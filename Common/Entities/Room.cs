using Common.Enums;
using Common.Interfaces;
using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Common.Entities
{
    public class Room
    {    
        [BsonId]
        public Guid Id { get; set; }
        public string RoomNumber { get; set; }
        public RoomType RoomType { get; set; }
        public BedType BedType { get; set; }
        public decimal PricePerNight { get; set; }
        public bool IsBooked { get; set; }        
    }
}
