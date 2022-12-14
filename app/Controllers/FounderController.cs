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
    public class FounderController : Controller
    {
        private readonly IFounderService _founderService;
        public FounderController(IFounderService founderService)
        {
            _founderService = founderService;
        }
        
        [HttpGet("{id}",Name ="GetFounderProfile")]  
        public async Task<ActionResult<ServiceResponse<FounderDTO>>> GetFounder(int id)
        {
            return Ok(await _founderService.GetFounderByUserId(id));
        }
        [HttpPut("UpdateFounderProfile")]
        public async Task<ActionResult<bool>> UpdateFounder([FromBody]FounderDTO founder)
        {
            return Ok(await _founderService.UpdateFounder(founder));
        }

    }
}