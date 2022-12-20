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

        [HttpGet("{id}",Name ="GetFounders")]
        public async Task<ActionResult<ServiceResponse<List<FounderDTO>>>> GetFoundersByUserId(int id)
        {
            return Ok(await _founderService.GetFoundersByUserId(id));
        }

        [HttpGet("{prId}/{userId}",Name ="GetFoundersByProjectId")]
        public async Task<ActionResult<ServiceResponse<List<FounderDTO>>>> GetFoundersByProjectId(int prId,int userId)
        {
            return Ok(await _founderService.GetFoundersByProjectId(prId,userId));
        }
    
        [HttpPost("PostFounder")]
        public async Task<ActionResult<bool>> AddFounder([FromBody]FounderDTO founder)
        {
            return Ok(await _founderService.AddFounder(founder));
        }

         [HttpPost("PostOtherFounder")]
        public async Task<ActionResult<bool>> AddOtherFounders([FromBody]PostOtherFoundersDTO founder)
        {
            return Ok(await _founderService.AddOtherFounders(founder));
        }

        [HttpPut("UpdateFounderProfile")]
        public async Task<ActionResult<bool>> UpdateFounder([FromBody]FounderDTO founder)
        {
            return Ok(await _founderService.UpdateFounder(founder));
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult<bool>> DeleteFounder(int id)
        {
            return Ok(await _founderService.DeleteFounder(id));
        }

    }
}