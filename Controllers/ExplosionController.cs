using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace _04_03_GET_practice_mode_api.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ExplodeController : ControllerBase
    {
        [HttpGet]
        public string Explode(string input)
        {
            string numbers = input == null ? "1" : input;

            try
            {
                var numbersAsList = numbers.Select(letter => $"{letter}").ToList();
                var numbersAddedAsString = "";

                for (var index = 0; index < numbersAsList.Count; index++)
                {
                    var selectedNumber = numbersAsList[index];

                    for (var addNumbers = 0; addNumbers < int.Parse(selectedNumber); addNumbers++)
                    {
                        numbersAddedAsString += selectedNumber;
                    }
                }

                return numbersAddedAsString;
            }
            catch (FormatException)
            {
                return "You added a letter didn't you...";
            }

        }
    }
}
