using Api_Ang_Demo.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Api_Ang_Demo.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class Products1Controller : ControllerBase
    {
        AngularDbContext db;
        public Products1Controller(AngularDbContext db1)
        {
            db = db1;
        }

        [HttpGet]
        public IActionResult Getall()
        {
            return Ok(db.Product);
        
        }
    }
}
