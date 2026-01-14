using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MiniChallenge6WebApi.Services
{
    public class Magic8BallService
    {
        
        public string Magic8Ball(string question)
        {
            if (!question.Trim().Contains("?"))
            {
                return "Your question needs to contain a ?";
            }
            int randomNum = Random.Shared.Next(1, 11);
            switch (randomNum)
                {
                        case 1:
                            return "Ask again later";
                        case 2:
                            return "I don't think so buddy!";
                        case 3:
                            return "Outlook not so good. :( ";
                        case 4:
                            return "Ehh No!";
                        case 5:
                            return "It is Not Likely Try again!";
                        case 6:
                            return "It is Very Likely!";
                        case 7:
                            return "Don't count on it.";
                        case 8:
                            return "Yes, definitely!";
                        case 9:
                            return "Without a doubt!";
                        default:
                            return "Ask again later";
                    }
}

    }
}