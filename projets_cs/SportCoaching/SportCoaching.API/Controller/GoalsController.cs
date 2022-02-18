using Microsoft.AspNetCore.Mvc;
using System.Linq;

namespace SportCoaching.API.Controller
{
    [ApiController]
    [Route("api/athletes/{athleteId}/goals")]
    public class GoalsController : ControllerBase
    {
        [HttpGet]
        public IActionResult GetGoalsByAthleteId(int athleteId)
        {
            var athlete = AthletesDataStore.Current.Athletes.FirstOrDefault(a => a.Id == athleteId);

            if (athlete == null)
            {
                return NotFound();
            }

            return Ok(athlete.Goals);
        }

        [HttpGet("{id}")]
        public IActionResult GetGoalByAthleteIdAndGoalId(int athleteId, int id)
        {
            var athlete = AthletesDataStore.Current.Athletes.FirstOrDefault(a => a.Id == athleteId);

            if (athlete == null)
            {
                return NotFound();
            }


            var goal = athlete.Goals.FirstOrDefault(g => g.Id == id);

            if (goal == null)
            {
                return NotFound();
            }
            return Ok(goal);
        }
    }
}
