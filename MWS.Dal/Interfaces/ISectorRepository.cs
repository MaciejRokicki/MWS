using System;
using System.Collections.Generic;
using MWS.Startup.ViewModels;

namespace MWS.Dal.Interfaces
{
    public interface ISectorRepository
    {
        SectorDbo GetSector(Func<SectorDbo, bool> getBy);
        IEnumerable<SectorDbo> GetSectors();
        IEnumerable<SectorDbo> GetSectors(Func<SectorDbo, bool> getBy);
    }
}
