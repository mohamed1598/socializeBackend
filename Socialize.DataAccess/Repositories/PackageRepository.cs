using Microsoft.EntityFrameworkCore;
using Socialize.DataAccess.Repositories.IRepositories;
using Socialize.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Socialize.DataAccess.Repositories
{
    public class PackageRepository : Repository<Package>,IPackageRepository
    {
        public PackageRepository(AppDBContext db) : base(db.Packages)
        {
        }

        public async Task<Package> Update(Package package)
        {
            var currentPackage = await GetFirstOrDefault(m => m.Id == package.Id);
            if (currentPackage == null) return null;
            currentPackage.Title = package.Title;
            currentPackage.PhoneNumber = package.PhoneNumber;
            currentPackage.Facebook = package.Facebook;
            currentPackage.Twitter = package.Twitter;
            currentPackage.Email = package.Email;
            currentPackage.Linkedin = package.Linkedin;
            currentPackage.GitHub = package.GitHub;
            currentPackage.Instagram = package.Instagram;
            currentPackage.PersonalWebsite = package.PersonalWebsite;
            currentPackage.UserName = package.UserName;
            return currentPackage;
        }
    }
}
