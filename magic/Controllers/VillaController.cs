using magic.Models;
using magic.Models.DTO;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace magic.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class VillaController : ControllerBase
    {

        [HttpGet]
        public IEnumerable<VillaDTO> GetVillas()
        {
            return new List<VillaDTO>
            {
                new VillaDTO {Id= 1, Name= "Pool View"},
                new VillaDTO {Id= 2,Name= "Beach View"}
            };
        }
    }
}
