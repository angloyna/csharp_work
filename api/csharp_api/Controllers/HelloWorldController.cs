using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace csharp_api.Controllers
{
    [ApiController]
    public class HelloWorldController : ControllerBase
    {
        private readonly ILogger<HelloWorldController> _logger;

        public HelloWorldController(ILogger<HelloWorldController> logger)
        {
            _logger = logger;
        }

       [HttpGet("hello")]
       public Greeting Get()
        {
            return new Greeting
            {
                message = "hello!"
            };
        }
    }
}
