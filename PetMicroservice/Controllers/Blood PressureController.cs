using Microsoft.AspNetCore.Mvc;
using PetMicroservice.Data.Entieties;
using PetMicroservice.Interfaces;
using PetMicroservice.ViewModels;

namespace PetMicroservice.Controllers
{
    
    [Route("api/[controller]")]
    [ApiController]
    public class BloodPressureController : Controller
    {
        private readonly PetTrackerContext _context;
        private readonly IBloodPressureServices _bloodPressureService;


        public BloodPressureController(PetTrackerContext context, IBloodPressureServices bloodPressureService)
        {
            _context = context;
            _bloodPressureService = bloodPressureService;
        }

        [HttpPost("add-bloodPressure")]
        public IActionResult AddBloodPressure([FromBody] BloodPressure bloodPressure)
        {
            _bloodPressureService.AddBloodPressure(bloodPressure);
            return Ok("Blood Pressure  u regjistru");
        }
        //public async Task<ActionResult<List<BloodPressure >>> AddBloodPressure (BloodPressure  bloodPressure)
        //{
        //    _context.BloodPressure .Add(bloodPressure);
        //    await _context.SaveChangesAsync();

        //    return Ok(await _context.BloodPressure .ToListAsync());
        //}
        [HttpGet]
        public IActionResult GetAllBloodPressure()
        {
            var bloodPressure = _bloodPressureService.GetAll();
            return Ok(bloodPressure);

        }


        [HttpGet("get-by-id /{id}")]
        public IActionResult GetPetById(int id)
        {
            var _bloodPressure = _bloodPressureService.BloodPressureById(id);
            return Ok(_bloodPressure);
        }

        [HttpPut("update-by-id/{Id}")]
        public IActionResult UpdateBloodPressure(int Id, [FromBody] BloodPressureVm bloodPressure)
        {
            var updatedBloodPressure = _bloodPressureService.UpdateBloodPressure(Id, bloodPressure);
            return Ok(updatedBloodPressure);
        }


        [HttpDelete("delete-bloodPressure{Id}")]
        public IActionResult DeleteBloodPressure(int Id)
        {
            _bloodPressureService.DeleteBloodPressure(Id);
            return Ok("BloodPressure  eshte fshrire");
        }
    }
}
