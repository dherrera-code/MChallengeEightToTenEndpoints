using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using MiniChallenge6WebApi.Services;

namespace MiniChallenge6WebApi.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    
    public class MagicEightBallController : ControllerBase
    {
    private readonly Magic8BallService _content;

        public MagicEightBallController(Magic8BallService content)
    {
        _content = content;
    }

        [HttpPost("/{askAQuestion}")]
        public string Magic8Ball(string askAQuestion)
        {
            return _content.Magic8Ball(askAQuestion);
        }
    }
}