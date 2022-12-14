using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using app.DLL.Models;
using app.ModelsDTO;
using app.Sevices.Abstract;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace app.Controllers
{
    [Route("[controller]")]
    public class PMController : Controller
    {
       private readonly IPMService _pmService;
        public PMController(IPMService pmService)
        {
            _pmService = pmService;
        }
        
        [HttpGet("{id}",Name ="GetPMProfile")]  
        public async Task<ActionResult<ServiceResponse<PMDTO>>> GetPM(int id)
        {
            return Ok(await _pmService.GetPMByUserId(id));
        }
        // [HttpPut("UpdateFounderProfile")]
        // public async Task<ActionResult<bool>> UpdateFounder([FromBody]FounderDTO founder)
        // {
        //     return Ok(await _pmService(founder));
        // }

    }
}