using System.Collections.Generic;
using MWS.Dal.Interfaces;
using MWS.Logic.Interfaces;
using MWS.Startup.ViewModels;

namespace MWS.Logic.Services
{
    public class PackageService : IPackageService
    {
        private readonly IPackageRepository packageRepository;

        public PackageService(IPackageRepository packageRepository)
        {
            this.packageRepository = packageRepository;
        }

        public PackageDbo GetPackage(int systemNumber, int specimen, int package)
        {
            PackageDbo result = packageRepository.GetPackage(x => x.SystemNumber == systemNumber && x.Specimen == specimen && x.Package == package);

            return result;
        }

        public IEnumerable<PackageDbo> GetPackages()
        {
            IEnumerable<PackageDbo> packages = packageRepository.GetPackages();

            return packages;
        }

        public IEnumerable<PackageDbo> GetPackagesByLocationId(int locationId)
        {
            IEnumerable<PackageDbo> packages = packageRepository.GetPackages(x => x.Location.Id == locationId);

            return packages;
        }

        public IEnumerable<PackageDbo> GetPackagesBySystemNumber(int systemNumber)
        {
            IEnumerable<PackageDbo> packages = packageRepository.GetPackages(x => x.SystemNumber == systemNumber);

            return packages;
        }
    }
}

