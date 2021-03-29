using System.Collections.Generic;
using MWS.Startup.ViewModels;

namespace MWS.Logic.Interfaces
{
	public interface IPackageService
    {
        PackageDbo GetPackage(int id);
        IEnumerable<PackageDbo> GetPackages();
        IEnumerable<PackageDbo> GetPackages(int locationId);
    }
}
