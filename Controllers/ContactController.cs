using AutoMapper;
using ClinicBackend.DTO;
using ClinicBackend.Service;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ClinicBackend.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ContactController : ControllerBase
    {
        private readonly IContact _contactRepository;
        private readonly IPatient _patientRepository;
        private readonly IMapper _mapper;

        public ContactController(IContact contactRepository, IPatient patientRepository, IMapper mapper)
        {
            _contactRepository = contactRepository;
            _patientRepository = patientRepository;
            _mapper = mapper;
        }

        public IContact ContactRepository { get; }

        [HttpGet("{id}")]
        [ProducesResponseType(200,Type = typeof(ICollection<ContactDTO>))]
        public IActionResult getAllContacts(int id)
        {
            var list = _mapper.Map<ICollection<ContactDTO>>(_contactRepository.getAll(id));

            return Ok(list);
        }

    }
}
