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
        }
    }
}
