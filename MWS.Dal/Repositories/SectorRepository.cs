using System;
using System.Linq;
using System.Text;
using System.Collections.Generic;
using Newtonsoft.Json;
using MWS.Dal.Interfaces;
using MWS.Startup.ViewModels;

namespace MWS.Dal.Repositories
{
    public class SectorRepository : ISectorRepository
    {
        private IEnumerable<SectorDbo> data;

        public SectorRepository()
        {
            string sectorsJson = Encoding.UTF8.GetString(Database.sectors);
            data = JsonConvert.DeserializeObject<List<SectorDbo>>(sectorsJson);
        }

        public SectorDbo GetSector(Func<SectorDbo, bool> getBy)
        {
            SectorDbo sector = data
                .Where(getBy)
                .FirstOrDefault();

            return sector;
        }

        public IEnumerable<SectorDbo> GetSectors() => data;

        public IEnumerable<SectorDbo> GetSectors(Func<SectorDbo, bool> getBy)
        {
            IEnumerable<SectorDbo> sectors = data
                .Where(getBy)
                .AsEnumerable<SectorDbo>();

            return sectors;
        }
    }
}
