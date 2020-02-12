using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using EDII_Lab2.Models;
using EDII_Lab2.Helpers;

namespace EDII_Lab2.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SodaController : ControllerBase
    {
       [HttpPost]
       public Soda Post ([FromBody] Soda soda)
        {
            Singleton.Instance.sodaList.Add(soda);
            return soda;
        }
    }
}