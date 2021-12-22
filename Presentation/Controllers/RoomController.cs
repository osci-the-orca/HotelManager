using Common.Entities;
using Common.Interfaces;
using Microsoft.AspNetCore.Mvc;
using Presentation.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Presentation.Controllers
{
    public class RoomController : Controller
    {

        private RoomViewModel _roomViewModel;
        private readonly IDataAccessRoom _dataAccessRoom;
        
        public RoomController(IDataAccessRoom dataAccessRoom)
        {
            _dataAccessRoom = dataAccessRoom;    
        }

        public IActionResult CreateRoom(RoomViewModel roomViewModel)
        {
            _dataAccessRoom.CreateDataBase("Rooms");
            Room room = new();
            

            room.RoomNumber = roomViewModel.RoomNumber;
            room.RoomType = roomViewModel.RoomType;
            room.BedType = roomViewModel.BedType;
            room.PricePerNight = roomViewModel.PricePerNight;


            _dataAccessRoom.InsertRoom("Rooms", room);
            return View("RoomView", roomViewModel);
        }

        public IActionResult Index()
        {
            return View();
        }
    }
}
