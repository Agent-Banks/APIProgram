
using System;
using Microsoft.AspNetCore.Mvc;

namespace APIProgram.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class MumblingController : ControllerBase
    {
        [HttpGet("{mumbling}")]
        public string Ramble(string mumbling)
        {
            // initialize a blank string and start count
            var answer = "";
            var count = 0;

            // loop through all chars in the string and upper all 
            foreach (char character in mumbling.ToUpper())
            {
                // if the next count != 0 insert a -
                if (count != 0) answer += "-";

                // add another char
                answer += character;
                // lower all chars that are not 0
                answer += new String(char.ToLower(character), count);

                ++count;
            }

            return answer;
        }
    }
}