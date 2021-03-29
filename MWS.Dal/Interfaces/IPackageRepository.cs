using System;
using System.Collections.Generic;
using MWS.Startup.ViewModels;

namespace MWS.Dal.Interfaces
{
    public interface IPackageRepository
    {
        PackageDbo GetPackage(Func<PackageDbo, bool> getBy);
        IEnumerable<PackageDbo> GetPackages();
        IEnumerable<PackageDbo> GetPackages(Func<PackageDbo, bool> getBy);
    }
}
