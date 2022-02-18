using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;

namespace SportCoaching.API.Controller
{
    [ApiController]
    [Route("api/athletes")]
    public class AthletesController : ControllerBase
    {
        [HttpGet]
        public IActionResult GetAthletes()
        {
            return Ok(AthletesDataStore.Current.Athletes);
        }
        [HttpGet("{id}")]
        public IActionResult GetAthleteById(int id)
        {
            var athleteToReturn = AthletesDataStore.Current.Athletes.FirstOrDefault(a => a.Id == id);

            if (athleteToReturn == null)
            {
               return NotFound();
            }

            return Ok(athleteToReturn);

        }

    }
}
