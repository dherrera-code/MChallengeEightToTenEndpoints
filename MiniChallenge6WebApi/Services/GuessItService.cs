using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MiniChallenge6WebApi.Services
{
    public class GuessItService
    {
        public string StartGameEasy(int guess)
        {
            int randomNum = Random.Shared.Next(1,11);
           if(guess > randomNum)
            {
                return $"Your guess of {guess} is HIGHER than the CPU number of {randomNum}! Game Over! Play Again!";
            }
            else if(guess < randomNum)
            {
                return $"Your guess of {guess} is LOWER than the CPU's number of {randomNum}! Game Over! Play Again!";
            }
            else
            return $"Your guess matches the CPU's Number {guess}! CONGRATULATIONS!!!";
        }
        public string StartGameMedium(int guess)
        {
            int randomNum = Random.Shared.Next(1,51);
           if(guess > randomNum)
            {
                return $"Your guess of {guess} is HIGHER than the CPU number of {randomNum}! Game Over! Play Again!";
            }
            else if(guess < randomNum)
            {
                return $"Your guess of {guess} is LOWER than the CPU's number of {randomNum}! Game Over! Play Again!";
            }
            else
            return $"Your guess matches the CPU's Number {guess}! CONGRATULATIONS!!!";
        }
        public string StartGameHard(int guess)
        {
            int randomNum = Random.Shared.Next(1,101);
           if(guess > randomNum)
            {
                return $"Your guess of {guess} is HIGHER than the CPU number of {randomNum}! Game Over! Play Again!";
            }
            else if(guess < randomNum)
            {
                return $"Your guess of {guess} is LOWER than the CPU's number of {randomNum}! Game Over! Play Again!";
            }
            else
            return $"Your guess matches the CPU's Number {guess}! CONGRATULATIONS!!!";
        }
    }
}