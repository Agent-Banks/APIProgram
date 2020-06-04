using System;
using Microsoft.AspNetCore.Mvc;

namespace APIProgram.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ExplosionController : ControllerBase
    {
        [HttpGet("{explosion}")]

        public string Boom(string explosion)
        {
            // create blank string for input of answer
            var answer = "";

            // split the string into numbers
            foreach (var character in explosion)
            {

                // add character to a string and convert it to an int value
                var number = int.Parse(character.ToString());

                // find the value of each individual number
                // duplicate the number as much as its value
                for (var n = 0; n < number; n++)
                {
                    answer += character;
                }
                // return the string of numbers that are duplicated
            }
            return answer;
        }
    }
}