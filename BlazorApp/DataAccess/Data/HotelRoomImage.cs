using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace DataAccess.Data
{
    public class HotelRoomImage
    {
        public int Id { get; set; }
        public int RoomId { get; set; }
        [ForeignKey("RoomId")]
        public virtual HotelRoom HotelRoom { get; set; }
        public string RoomImageUrl { get; set; }
        
    }
}
