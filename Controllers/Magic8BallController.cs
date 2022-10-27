// Andrew Nilsson
// 10/27/22
// Magic 8 Ball - Endpoint
// A webapi that outputs a random string when called
// Peer Review by Lerissa Lazar - the code works well, but the answers were lammmmeeeeeeeeeeeee and not creative. good job burger


using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace NilssonA_Magic8BallEnpoint.Controllers
{
    [Route("[controller]")]
    public class Magic8BallController : Controller
    {
        [HttpGet]
        [Route("Answer")]
        public string Answer()
        {
            Random rnd = new Random();

            string[] answers = {"Yes", "No", "Maybe", "IDK", "Sure"};

            int index = rnd.Next(answers.Length);

            return answers[index];
        }
    }
}