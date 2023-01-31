using Socialize.DataAccess.Repositories.IRepositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Socialize.DataAccess.Repositories
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly AppDBContext db;
        public UnitOfWork(AppDBContext db)
        {
            this.db = db;
            Packages = new PackageRepository(db);
        }
        public IPackageRepository Packages { get; set; }
        public IUserRepository Users { get; set; }

        public void Save()
        {
            db.SaveChanges();
        }

        public async Task SaveAsync()
        {
            await db.SaveChangesAsync();
        }
    }
}
