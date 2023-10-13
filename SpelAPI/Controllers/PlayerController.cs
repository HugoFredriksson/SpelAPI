using Microsoft.AspNetCore.Mvc;

namespace SpelAPI.Controllers
{
    [ApiController]
    [Route("api/player")]
    public class PlayerController : Controller
    {
        [HttpGet("{id}")]
        public ActionResult<PlayerInformation> GetPlayerInfo(int id)
        {
            return View();
        }

        [HttpGet("{id}/latest_game")] 
        public ActionResult<PlayerLatestGame> GetPlayerLatestGame(int id) 
        {
            return View();
        }

        [HttpGet("{id}/top_characters")]
        public ActionResult<PlayerTopCharacters> GetPlayerTopCharacters(int id)
        {
            return View();
        }

        [HttpPut("{id}")] 
        public ActionResult<UpdatePlayerInformation> UpdatePlayerInformation(int id, PlayerInformation playerinformation)
        {
            if (playerinformation == null)
            {
                return StatusCode(404);
            }
        } 
    }
}
