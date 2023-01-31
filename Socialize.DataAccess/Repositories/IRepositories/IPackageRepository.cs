using Socialize.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Socialize.DataAccess.Repositories.IRepositories
{
    public interface IPackageRepository:IRepository<Package>
    {
        Task<Package> Update(Package package);
    }
}
