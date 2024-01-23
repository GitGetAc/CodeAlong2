namespace CodeAlong2
{
    internal class Floor
    {
        private List<Room> RoomsOnFloor { get; set; }

        private int FloorNumber { get; set; }

        public Floor(int floorNumber, List<Room> room)
        {
            FloorNumber = floorNumber;
            RoomsOnFloor = room;
        }
    }
}