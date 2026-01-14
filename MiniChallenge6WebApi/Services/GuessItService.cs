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

            if(guess > 10 || guess < 0)
            {
                return $"Your guess is outside the bounds of the guessing range! In easy mode, the range is from 1 to 10!";
            }
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

            if(guess > 50 || guess < 0)
            {
                return $"Your guess is outside the bounds of the guessing range! In easy mode, the range is from 1 to 50!";
            }
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
            if(guess > 100 || guess < 0)
            {
                return $"Your guess is outside the bounds of the guessing range! In easy mode, the range is from 1 to 100!";
            }
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