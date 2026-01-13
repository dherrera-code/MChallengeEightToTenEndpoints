using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using MiniChallenge6WebApi.Services;

namespace MiniChallenge6WebApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class GuessItController : ControllerBase
    {
        private readonly GuessItService _guessIt;
        public GuessItController (GuessItService guessIt)
        {
            _guessIt = guessIt;
        }
        //Have one endpoint accept an input for difficulty and generate a random number!
        [HttpPost("SetDifficulty/EasyMediumHard{difficulty}")]
        public string GetDifficulty(string difficulty)
        {
            return _guessIt.StartGame(difficulty);
        }

        //Have one endpoint that allows user to enter a guess and return either a higher, lower or spot on!
        //Have one endpoint GET the state of the game, is a game active, and if active, display difficulty, previous guess, and current guess count. 
    }
}