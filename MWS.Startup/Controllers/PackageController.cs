using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using AutoMapper;
using MWS.Logic.Interfaces;
using MWS.Startup.ViewModels;

namespace MWS.Startup.Controllers
{
    [Route("api/[Controller]/[Action]")]
    [ApiController]
    public class PackageController : ControllerBase
    {
        private readonly IPackageService packageService;
        private readonly IMapper mapper;

        public PackageController(IPackageService packageService, IMapper mapper)
        {
            this.packageService = packageService;
            this.mapper = mapper;
        }

        [HttpGet]
        public ActionResult<PackageViewModel> GetPackage(int systemNumber, int specimen, int package)
        {
            PackageDbo packageDbo = packageService.GetPackage(systemNumber, specimen, package);

            PackageViewModel result = mapper.Map<PackageViewModel>(packageDbo);

            return Ok(result);
        }

        [HttpGet]
        public ActionResult<IEnumerable<PackageViewModel>> GetPackages()
        {
            IEnumerable<PackageDbo> resultDbo = packageService.GetPackages();

            IEnumerable<PackageViewModel> result = mapper.Map<IEnumerable<PackageViewModel>>(resultDbo);

            return Ok(result);
        }

        [HttpGet("{locationId}")]
        public ActionResult<IEnumerable<PackageViewModel>> GetPackagesByLocationId(int locationId)
        {
            IEnumerable<PackageDbo> resultDbo = packageService.GetPackagesByLocationId(locationId);

            IEnumerable<PackageViewModel> result = mapper.Map<IEnumerable<PackageViewModel>>(resultDbo);

            return Ok(result);
        }

        [HttpGet("{systemNumber}")]
        public ActionResult<IEnumerable<PackageViewModel>> GetPackagesBySystemNumber(int systemNumber)
        {
            IEnumerable<PackageDbo> resultDbo = packageService.GetPackagesBySystemNumber(systemNumber);

            IEnumerable<PackageViewModel> result = mapper.Map<IEnumerable<PackageViewModel>>(resultDbo);

            return Ok(result);
        }
    }
}
