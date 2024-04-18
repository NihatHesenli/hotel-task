using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5
{
    internal class Hotel
    {
        public int id {  get; set; }
        public string name { get; set; }
        List<Room> rooms { get; set; }
        public Hotel(string name)
        {
            this.name = name;
            rooms = new List<Room>();

        }
        public void AddRoom(Room room)
        {
            rooms.Add(room);
        }
        public void MakeReservation(int roomId)
        {

            if (roomId = null) new NullReferenceException("Id sehv daxil olunub");

            foreach (Room room in rooms)
            {
                if (room.Id == roomId)
                {
                    if (room.IsAviable)
                    {
                        Console.WriteLine("rezerv olundu");
                        room.IsAviable = false;

                    }
                    else
                    {
                        Console.WriteLine("artiq rezerv olunub")
                    }
                }
            }
        }
    }
}
