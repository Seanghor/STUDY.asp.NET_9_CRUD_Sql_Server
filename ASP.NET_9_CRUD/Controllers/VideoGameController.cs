
using ASP.NET_9_CRUD.Data;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace ASP.NET_9_CRUD.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class VideoGameController(VideoGameDbContext context) : ControllerBase
    {
        //Inject data context  --> we can access database
        private readonly VideoGameDbContext _context = context;

        //-- Get All ---
        [HttpGet]
        public async Task<ActionResult<List<VideoGame>>> GetVideoGames()
        {
            var videoGames = await _context.VideoGames.ToListAsync();
            for (int i = 0; i < videoGames.Count; i++)
            {
                var videoGame = videoGames[i];
                Console.WriteLine($"Video Game {i + 1}: {videoGame.Title}"); 

            }
            return Ok(videoGames);
            //return Ok(await _context.VideoGames.ToListAsync());
        }


        //-- Get One
        [HttpGet("getOne/{id}")]  //base/getOne/id
        public async Task<ActionResult<VideoGame>> GetOneVideoGameById(int id)
        {
            Console.WriteLine(">>>>>>>>>> Get VideoGame ID:" + id);
            var exitVideoGame = await _context.VideoGames.FindAsync(id);

            if (exitVideoGame is null)
                return NotFound();
            return Ok(exitVideoGame);
        }


        // -- Create 
        [HttpPost]
        public async Task<ActionResult<VideoGame>> CreateVideoGame(VideoGame newItem)
        {
            if (newItem == null)
                return BadRequest();
            _context.VideoGames.Add(newItem);
            await _context.SaveChangesAsync();
            return CreatedAtAction(nameof(GetOneVideoGameById), new { id = newItem.Id }, newItem);
        }


        //-- Update 
        [HttpPatch("update/{id}")]  //base/update/id
        public async Task<IActionResult> UpdateVideoGameById(int id, VideoGame updatedGame)
        {
            Console.WriteLine(">>>>>>>>>> Update VideoGame ID:" + id);
            var exitVideoGame = await _context.VideoGames.FindAsync(id);

            if (exitVideoGame is null)
                return NotFound();
            exitVideoGame.Title = updatedGame.Title;
            exitVideoGame.Platform = updatedGame.Platform;
            exitVideoGame.Publisher = updatedGame.Publisher;
            exitVideoGame.Developer = updatedGame.Developer;
            await _context.SaveChangesAsync();
            return NoContent();
        }



        //-- Delete
        [HttpDelete("delete/{id}")]
        public async Task<IActionResult> DeleteVideoGameById(int id)
        {
            var existingGame = await _context.VideoGames.FindAsync(id);
            Console.WriteLine(">>>>>>>>>> Delete VideoGame ID:" + id);
            Console.WriteLine("VideoGame ID:" + existingGame);
            if (existingGame is null)
                return NotFound();
            _context.VideoGames.Remove(existingGame);
            await _context.SaveChangesAsync();
            return NoContent();
        }
    }
}
