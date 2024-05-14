using DoctorClinicAPI.Exceptions;
using DoctorClinicAPI.Interfaces;
using DoctorClinicAPI.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace DoctorClinicAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DoctorController : ControllerBase
    {
        private readonly IDoctorService _DoctorService;

        public DoctorController(IDoctorService DoctorService)
        {
            _DoctorService = DoctorService;
        }
        [HttpGet]
        public async Task<ActionResult<IList<Doctor>>> Get()
        {
            try
            {
                var Doctors = await _DoctorService.GetDoctors();
                return Ok(Doctors.ToList());
            }
            catch (NoDoctorFoundException nefe)
            {
                return NotFound(nefe.Message);
            }
        }
        [HttpPut]
        public async Task<ActionResult<Doctor>> Put(int id, double Experience)
        {
            try
            {
                var Doctor = await _DoctorService.UpdateDoctorExperience(id, Experience);
                return Ok(Doctor);
            }
            catch (NoDoctorFoundException nsee)
            {
                return NotFound(nsee.Message);
            }
        }
        [Route("GetDoctorBySpecialization")]
        [HttpPost]
        public async Task<ActionResult<Doctor>> Get([FromBody] string speciality)
        {
            try
            {
                var Doctor = await _DoctorService.GetDoctorBySpeciality(speciality);
                return Ok(Doctor);
            }
            catch (NoDoctorFoundException nefe)
            {
                return NotFound(nefe.Message);
            }
        }

    }
}
