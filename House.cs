namespace CodeAlong2
{
    internal class House
    {
        private List<Floor> FloorsInTheHouse { get; set; }

        public House(List<Floor> floor)
        {
            FloorsInTheHouse = floor;
        }
    }
}
