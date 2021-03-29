using System.Collections.Generic;
using MWS.Startup.ViewModels;

namespace MWS.Logic.Interfaces
{
    public interface ISectorService
    {
        SectorDbo GetSector(int id);
        IEnumerable<SectorDbo> GetSectors();
    }
}
