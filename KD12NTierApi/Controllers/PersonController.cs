using KD12NTierApi.Bussiness.Abstract;
using KD12NTierApi.Entities.Concrete;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using KD12NTierApi.Core.Enums;

namespace KD12NTierApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PersonController : ControllerBase
    {
        private readonly IPersonService _personService;
        public PersonController(IPersonService personService)
        {
            _personService = personService;
        }
        [HttpGet("{id}")]
        public async Task<ActionResult<Person>> GetById(int id)
        {
            var personel = await _personService.GetByID(id);
            if (personel == null)
            {
                return NotFound();
            }

            return Ok(personel);
        }

        [HttpPost]
        public async Task<ActionResult<Person>> PostPerson([FromBody] Person person)
        {

            try
            {
                await _personService.Add(person);

            }
            catch (Exception)
            {

                return NotFound();
            }

            return CreatedAtAction("GetById", new { Id = person.Id }, person);
        }

        [HttpPut("{id}")]
        public async Task<ActionResult<Person>> UpdatePerson(int id, Person person)
        {
            var findPerson = await _personService.GetByID(id);
            if (findPerson == null)
            {
                return NotFound();
            }
            else
            {
                findPerson.Name = person.Name;
                findPerson.Surname = person.Surname;
                findPerson.TcNo = person.TcNo;

                await _personService.Update(findPerson);

                return Ok(findPerson);
            }
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult<Person>> DeletePerson(int id)
        {
            var deletePerson = await _personService.GetByID(id);
            if (deletePerson == null)
            {
                return NotFound();
            }
            else
            {
                deletePerson.Status = Status.Passive;
                await _personService.Update(deletePerson);
                return Ok(deletePerson);
            }

        }

        [HttpGet]
        public async Task<ActionResult<List<Person>>> GetAllPerson()
        {
            var personList = await _personService.GetAll();

            if (personList == null)
            {
                return NotFound();
            }
            else
                return Ok(personList);
        }
    }
}
