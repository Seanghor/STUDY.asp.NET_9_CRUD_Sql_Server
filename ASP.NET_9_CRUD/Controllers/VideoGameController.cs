using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ASP.NET_9_CRUD.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class VideoGameController : ControllerBase
    {
        private readonly ILogger<VideoGameController> _logger;

        public VideoGameController(ILogger<VideoGameController> logger)
        {
            _logger = logger;
        }

        static private List<VideoGame> videoGames = new List<VideoGame>()
        {
           new VideoGame
           {
                Id = 1,
                Title = "Test",
                Platform = "PS5",
                Developer = "Seanghor",
                Publisher = "Sony Interactive Entertainment"
           },
           new VideoGame
           {
                Id = 2,
                Title = "Adventure Quest",
                Platform = "PS4",
                Developer = "Game Studio",
                Publisher = "Big Games Inc."
           },
            new VideoGame
            {
                Id = 3,
                Title = "Battle Royale",
                Platform = "PC",
                Developer = "Epic Developers",
                Publisher = "Super Games Co."
            },
            new VideoGame
            {
                Id = 4,
                Title = "Racing Rivals",
                Platform = "Xbox",
                Developer = "SpeedWorks",
                Publisher = "Turbo Media"
            },
            new VideoGame
            {
                Id = 5,
                Title = "Space Odyssey",
                Platform = "PS5",
                Developer = "Galaxy Studios",
                Publisher = "Cosmic Entertainment"
            },
            new VideoGame
            {
                Id = 6,
                Title = "Zombie Defense",
                Platform = "PC",
                Developer = "Survival Games",
                Publisher = "Apocalypse Studios"
            },
            new VideoGame
            {
                Id = 7,
                Title = "Fantasy World",
                Platform = "PS4",
                Developer = "Fantasy Makers",
                Publisher = "DreamWorks Entertainment"
            }

        };

        //Get All 
        [HttpGet]
        public ActionResult<List<VideoGame>> GetVideoGames()
        {
            return Ok(videoGames);
        }

        //Get One
        [HttpGet("getOne/{id}")]  //base/getOne/id
        public ActionResult<VideoGame> GetOneVideoGame(int id)
        {
            Console.WriteLine(">>>>>>>>>> Get VideoGame ID:" + id);
            //_logger.LogInformation("Getting VideoGame with ID: {Id}", id);
            var videoGame = videoGames.FirstOrDefault(item => item.Id == id);

            if(videoGame is null)
                return NotFound();
            return Ok(videoGame);
        }

        //Create 
        [HttpPost]
        public ActionResult<VideoGame> CreateVideoGame(VideoGame newItem)
        {
            if (newItem == null)
                return BadRequest();
            int maxId = videoGames.Max(item => item.Id);
            newItem.Id = maxId + 1;
            //add item into array
            videoGames.Add(newItem);
            return CreatedAtAction(nameof(GetOneVideoGame), new { id = newItem.Id }, newItem);
        }

        //Update:
        [HttpPut("{id}")]
        //IActionResult : not return anything
        public IActionResult UpdateVideoGameById(int id, VideoGame updatedVideoGame)
        {
            var videoGame = videoGames.FirstOrDefault(item => item.Id == id);
            if (videoGame is null)
                return NotFound();
            //videoGame = updatedVideoGame;
            videoGame.Title = updatedVideoGame.Title;
            videoGame.Platform = updatedVideoGame.Platform;
            videoGame.Developer = updatedVideoGame.Developer;
            videoGame.Publisher = updatedVideoGame.Publisher;
            return NoContent();
        }


        //Delete
        [HttpDelete("{id}")]
        public IActionResult DeleteOneVideoGameById(int id)
        {
            var existVideoGame = videoGames.FirstOrDefault(item => item.Id == id);
            if (existVideoGame is null)
                return NotFound();
            videoGames.Remove(existVideoGame);
            return NoContent();
        }
    }
}
