namespace MWS.Startup.ViewModels
{
    public class PackageDbo
    {
        public int SystemNumber { get; set; }
        public int Specimen { get; set; }
        public int Package { get; set; }
        public string ArticleCode { get; set; }
        public DimensionDbo Dimensions { get; set; }
        public LocationDbo Location { get; set; }
    }
}
