using System;
using System.Linq;
using System.Text;
using System.Collections.Generic;
using Newtonsoft.Json;
using MWS.Dal.Interfaces;
using MWS.Startup.ViewModels;

namespace MWS.Dal.Repositories
{
    public class PackageRepository : IPackageRepository
    {
        private IEnumerable<PackageDbo> data;

        public PackageRepository()
        {
            string packagesJson = Encoding.UTF8.GetString(Database.packages);
            data = JsonConvert.DeserializeObject<List<PackageDbo>>(packagesJson);
        }

        public PackageDbo GetPackage(Func<PackageDbo, bool> getBy)
        {
            PackageDbo package = data
                .Where(getBy)
                .FirstOrDefault();

            return package;
        }

        public IEnumerable<PackageDbo> GetPackages() => data;

        public IEnumerable<PackageDbo> GetPackages(Func<PackageDbo, bool> getBy)
        {
            IEnumerable<PackageDbo> packages = data
                .Where(getBy)
                .AsEnumerable<PackageDbo>();

            return packages;
        }
    }
}
