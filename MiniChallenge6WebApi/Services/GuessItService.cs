using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MiniChallenge6WebApi.Services
{
    public class GuessItService
    {
        //Have one endpoint accept an input for difficulty and generate a random number!
        public int _randomNum {set; get;}
        public int guessCounter {set; get;}
        public string _difficulty = ""; 
        public string StartGame(string difficulty)
        {
            guessCounter = 0;
            _difficulty = difficulty;

            if(difficulty.Trim().ToLower() == "easy")
            {
                _randomNum = Random.Shared.Next(1,11);
            }
            else if(difficulty.Trim().ToLower() == "medium")
            {
                _randomNum = Random.Shared.Next(1,51);
            }
            else if(difficulty.Trim().ToLower() == "hard")
            {
                _randomNum = Random.Shared.Next(1,101);
            }
            else
            {
                _difficulty = "";
                return "Invalid Difficulty Input: Please enter Easy, Medium, or Hard!";
            }
            return $"You have selected {difficulty.ToUpper()} difficulty! A number has been generated! Make your Guess! {_randomNum}";
        }
        //Have one endpoint that allows user to enter a guess and return either a higher, lower or spot on!
        public string CheckGuess(int guess)
        {
            // if(_difficulty == "") return "Game is Not Active! Please Set a difficulty first!";
            guessCounter++;
            if(guess > _randomNum)
            {
                return $"Your Guess {guess} is Higher than the CPU's number!";
            }
            else if(guess < _randomNum)
            {
                return $"Your Guess {guess} is Lower than the CPU's number!";
            }
            else
            {
                return $"You've successfully guessed the CPU's Number!! The Number is {_randomNum}! Your total guesses are {guessCounter}";
            }
        }
        //Have one endpoint GET the state of the game, is a game active, and if active, display difficulty, previous guess, and current guess count. 
    }
}