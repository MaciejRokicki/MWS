namespace MWS.Startup.ViewModels
{
    public class PackageViewModel
    {
        public int SystemNumber { get; set; }
        public int Specimen { get; set; }
        public int Package { get; set; }
        public string ArticleCode { get; set; }
        public DimensionViewModel Dimension { get; set; }
        public LocationViewModel Location { get; set; }
    }
}
