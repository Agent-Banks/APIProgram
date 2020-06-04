
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
            var answer = "";
            var count = 0;
            foreach (char character in mumbling.ToUpper())
            {
                if (count != 0) answer += "-";
                answer += character;
                answer += new String(char.ToLower(character), count);
                ++count;
            }
            return answer;
        }
    }
}