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

        public PackageDbo GetPackage(int id)
        {
            PackageDbo package = packageRepository.GetPackage(x => x.Package == id);

            return package;
        }

        public IEnumerable<PackageDbo> GetPackages()
        {
            IEnumerable<PackageDbo> packages = packageRepository.GetPackages();

            return packages;
        }

        public IEnumerable<PackageDbo> GetPackages(int locationId)
        {
            IEnumerable<PackageDbo> packageDbo = packageRepository.GetPackages(x => x.Location.Id == locationId);

            return packageDbo;
        }
    }
}

