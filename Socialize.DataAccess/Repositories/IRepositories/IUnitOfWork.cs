using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Socialize.DataAccess.Repositories.IRepositories
{
    public interface IUnitOfWork
    {
        public IPackageRepository Packages { get; set; }
        public IUserRepository Users { get; set; }
        void Save();
        Task SaveAsync();
    }
}
