using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace _04_03_get_practice_api.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class MumbleController : ControllerBase
    {

        [HttpGet]
        public string Mumble(string input)
        {
            string letters = input == null ? "you did not give me a word" : input;

            var stringLowerCased = letters.ToLower();
            var untrimmedString = "";

            for (var index = 0; index < stringLowerCased.Length; index++)
            {
                var letterSelected = stringLowerCased[index];
                var processedLetter = "";

                for (var addLetters = 0; addLetters < index + 1; addLetters++)
                {
                    processedLetter += letterSelected;
                }

                untrimmedString += Char.ToUpper(processedLetter[0]) + processedLetter.Substring(1) + "-";
            }

            return untrimmedString.Trim(untrimmedString[untrimmedString.Length - 1]);
        }
    }
}
