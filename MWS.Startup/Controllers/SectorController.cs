using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using AutoMapper;
using MWS.Logic.Interfaces;
using MWS.Startup.ViewModels;

namespace MWS.Startup.Controllers
{
    [Route("api/[Controller]/[Action]")]
    [ApiController]
    public class SectorController : ControllerBase
    {
        private readonly ISectorService sectorService;
        private readonly IMapper mapper;

        public SectorController(ISectorService sectorService, IMapper mapper)
        {
            this.sectorService = sectorService;
            this.mapper = mapper;
        }

        [HttpGet("{id}")]
        public ActionResult<SectorViewModel> GetSector(int id)
        {
            SectorDbo sectorDbo = sectorService.GetSector(id);

            SectorViewModel sectorViewModel = mapper.Map<SectorViewModel>(sectorDbo);

            return Ok(sectorViewModel);
        }

        [HttpGet]
        public ActionResult<SectorViewModel> GetSector(int x, int y, int z)
        {
            SectorDbo sectorDbo = sectorService.GetSector(x, y, z);

            SectorViewModel sectorViewModel = mapper.Map<SectorViewModel>(sectorDbo);

            return Ok(sectorViewModel);
        }

        [HttpGet]
        public ActionResult<IEnumerable<SectorViewModel>> GetSectors()
        {
            IEnumerable<SectorDbo> resultDbo = sectorService.GetSectors();

            IEnumerable<SectorViewModel> result = mapper.Map<IEnumerable<SectorViewModel>>(resultDbo);

            return Ok(result);
        }
    }
}
