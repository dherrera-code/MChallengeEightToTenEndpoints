using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using MiniChallenge6WebApi.Services;
using MiniChallenge6WebApi.Models;
// using MiniChallenge6WebApi.Data;

namespace MiniChallenge6WebApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class GuessItController : ControllerBase
    {
        private readonly GuessItService _guessIt;
        // private readonly AppDbContext _context;
        public GuessItController (GuessItService guessIt)
        {
            _guessIt = guessIt;
            // _context = context;
        }

        //Have one endpoint accept an input for difficulty and generate a random number!
        [HttpPost("SetDifficulty/EasyMediumHard{difficulty}")]

        // public async Task<IActionResult> StartGame(GuessIt guessItGame, string difficulty)
        // {
        //     if(!ModelState.IsValid) return BadRequest(ModelState);

        //     await _context.AddAsync(guessItGame);
        //     var result = await _context.SaveChangesAsync();
        //     if(result > 0)
        //     {
        //         return Ok();//Functions from EF core dbCOntext
        //     }
        //     return BadRequest();
        // }
        public string GetDifficulty(string difficulty)
        {
            return _guessIt.StartGame(difficulty);
        }


        [HttpPost("CheckYourGuess/{guess}")]
        public string CheckGuess(int guess)
        {
            return _guessIt.CheckGuess(guess);
        }

        //Have one endpoint that allows user to enter a guess and return either a higher, lower or spot on!
        //Have one endpoint GET the state of the game, is a game active, and if active, display difficulty, previous guess, and current guess count. 
    }
}