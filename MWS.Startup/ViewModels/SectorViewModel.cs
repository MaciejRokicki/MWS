namespace MWS.Startup.ViewModels
{
    public class SectorViewModel
    {
        public int Id { get; set; }
        public int X { get; set; } //TODO: float ???
        public int Y { get; set; } //TODO: float ???
        public int Z { get; set; } //TODO: float ???
        public float Width { get; set; }
        public float Depth { get; set; }
        public float Height { get; set; }
    }
}
