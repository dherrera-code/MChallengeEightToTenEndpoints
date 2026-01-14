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
        [HttpPost("PlayEasyMode/{guess}")]
        public string GuessEasyMode(int guess)
        {
            return _guessIt.StartGameEasy(guess);
        }
        [HttpPost("PlayMediumMode/{guess}")]
        public string GuessMediumMode(int guess)
        {
            return _guessIt.StartGameMedium(guess);
        }

[HttpPost("PlayHardMode/{guess}")]
        public string GuessHardMode(int guess)
        {
            return _guessIt.StartGameHard(guess);
        }




    }
}