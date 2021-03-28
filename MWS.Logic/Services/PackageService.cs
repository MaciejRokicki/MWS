using System;
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
            PackageDbo packageDbo = packageRepository.GetPackage(x => x.Id == id);

            return packageDbo;
        }

    }
}

