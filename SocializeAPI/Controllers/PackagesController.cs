using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Socialize.DataAccess.Repositories.IRepositories;
using Socialize.Models;

namespace SocializeAPI.Controllers
{
    // not tested yet
    [Route("api/[controller]")]
    [ApiController]
    public class PackagesController : ControllerBase
    {
        private readonly IUnitOfWork unitOfWork;
        public PackagesController(IUnitOfWork unitOfWork)
        {
            this.unitOfWork = unitOfWork;
        }
        [HttpGet]
        public async Task<ActionResult<List<Package>>> GetAllPackages()
        {
            var packages = await unitOfWork.Packages.GetAll();
            return Ok(packages);
        }

        [HttpGet("{id:Guid}")]
        public async Task<ActionResult<Package>> GetPackageById(Guid id)
        {
            var package = await unitOfWork.Packages.GetFirstOrDefault(m => m.Id == id);
            return Ok(package);
        }
        [HttpPost]
        public async Task<ActionResult> CreatePackage(Package package)
        {
            await unitOfWork.Packages.Add(package);
            await unitOfWork.SaveAsync();
            return Ok(package);
        }
        [HttpPut]
        public async Task<ActionResult<Package>> UpdatePackage(Package package)
        {
            var pack = await unitOfWork.Packages.Update(package);
            await unitOfWork.SaveAsync();
            return Ok(package);
        }
        [HttpDelete("{id:Guid}")]
        public async Task<ActionResult> DeletePackage(Guid id)
        {
            var package = await unitOfWork.Packages.GetFirstOrDefault(m => m.Id == id);
            unitOfWork.Packages.Remove(package);
            unitOfWork.Save();
            return Ok("deleted");
        }
    }
}
