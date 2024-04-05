using Microsoft.AspNetCore.Mvc;
using OnlineMuhasebeServer.Presentation.Abstraction;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineMuhasebeServer.Presentation.Controller
{
    public sealed class TestController :ApiController
        //sealed inherit edilmesini engeller
    {
        [HttpGet]
        public IActionResult GET()
        {
            {
                return Ok("işlem Başarılı");
            }
        }
    }
}
