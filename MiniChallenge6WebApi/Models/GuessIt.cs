using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MiniChallenge6WebApi.Models
{
    public class GuessIt 
    {
        //Define the shape of our GuessIt information
        //This will tell our database how we want our tables to be set up!
        //We need DbContext to manage and communicate our database.
        public int Id { get; set; }
        public int RandomNum { get; set; }
        public int GuessCounter { get; set; }
        public string? Difficulty { get; set; }
    }
}