using AutoMapper;
using ClinicBackend.DTO;
using ClinicBackend.Models;
using ClinicBackend.Service;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ClinicBackend.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PatientController : ControllerBase
    {
        private readonly IPatient _patientRepository;
        private readonly IMapper _mapper;

        public PatientController(IPatient patientRepository, IMapper mapper)
        {
            _patientRepository = patientRepository;
            this._mapper = mapper;
        }

        [HttpGet]
        [ProducesResponseType(200, Type = typeof(ICollection<PatientDTO>))]
        public IActionResult getPatients()
        {
            var patients = _mapper.Map<List<PatientDTO>>(_patientRepository.getAll());
            return Ok(patients);
        }

        [HttpGet("{id}")]
        [ProducesResponseType(200, Type = typeof(PatientDTO))]
        [ProducesResponseType(400)]
        public IActionResult getPatient(int id) {
            if (!_patientRepository.isExist(id))
            {
                return NotFound();
            }
            var patient = _mapper.Map<PatientDTO>(_patientRepository.getById(id));
            return Ok(patient);
        }

        [HttpPost]
        public IActionResult createPatient([FromBody] PatientDTO patientDTO)
        {
            if (patientDTO == null) {
                return BadRequest();
            }
            var newPatient = _mapper.Map<Patient>(patientDTO);
            if (!_patientRepository.createPatient(newPatient))
            {
                ModelState.AddModelError("", "Error appears while saving!!!");
                return StatusCode(500,ModelState);
            }
            
            return Ok("Patient created!");
        }

        [HttpPut]
        public IActionResult updatePatient([FromBody] PatientDTO patientDTO)
        {
            if (patientDTO == null)
            {
                return BadRequest();
            }
            var newPatient = _mapper.Map<Patient>(patientDTO);
            if (!_patientRepository.updatePatient(newPatient))
            {
                ModelState.AddModelError("", "Error appears while saving!!!");
                return StatusCode(500, ModelState);
            }

            return Ok("Patient updated!");
        }
    }
}
