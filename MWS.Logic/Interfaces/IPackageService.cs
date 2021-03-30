using System.Collections.Generic;
using MWS.Startup.ViewModels;

namespace MWS.Logic.Interfaces
{
	public interface IPackageService
    {
        PackageDbo GetPackage(int systemNumber, int specimen, int package);
        IEnumerable<PackageDbo> GetPackages();
        IEnumerable<PackageDbo> GetPackagesByLocationId(int locationId);
        IEnumerable<PackageDbo> GetPackagesBySystemNumber(int systemNumber);

    }
}
