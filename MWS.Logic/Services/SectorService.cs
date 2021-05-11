using System.Collections.Generic;
using MWS.Dal.Interfaces;
using MWS.Logic.Interfaces;
using MWS.Startup.ViewModels;

namespace MWS.Logic.Services
{
    public class SectorService : ISectorService
    {
        private readonly ISectorRepository sectorRepository;

        public SectorService(ISectorRepository sectorRepository)
        {
            this.sectorRepository = sectorRepository;
        }

        public SectorDbo GetSector(int id)
        {
            SectorDbo sectorDbo = sectorRepository.GetSector(x => x.Id == id);

            return sectorDbo;
        }

        public SectorDbo GetSector(int x, int y, int z)
        {
            SectorDbo sectorDbo = sectorRepository.GetSector(s => s.X == x && s.Y == y && s.Z == z);

            return sectorDbo;
        }

        public IEnumerable<SectorDbo> GetSectors()
        {
            IEnumerable<SectorDbo> sectors = sectorRepository.GetSectors();

            return sectors;
        }
    }
}
