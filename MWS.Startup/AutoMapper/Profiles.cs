using AutoMapper;
using MWS.Startup.ViewModels;

namespace MWS.Startup.AutoMapper
{
    public class Profiles : Profile
    {
        public Profiles()
        {
            CreateMap<SectorViewModel, SectorDbo>()
                .ReverseMap();

            CreateMap<DimensionViewModel, DimensionDbo>()
                .ReverseMap();

            CreateMap<LocationViewModel, LocationDbo>()
                .ReverseMap();

            CreateMap<PackageViewModel, PackageDbo>()
                .ReverseMap();
        }
    }
}
