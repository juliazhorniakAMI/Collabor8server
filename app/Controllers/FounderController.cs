using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using app.DLL.Models;
using app.ModelsDTO;
using app.ModelsDTO.Founders;
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

        [HttpGet("GetFoundersByUserId/{userId}")]
        public async Task<ActionResult<ServiceResponse<List<FounderDTO>>>> GetFoundersByUserId(int userId)
        {
            return Ok(await _founderService.GetFoundersByUserId(userId));
        }

        [HttpGet("GetOtherFoundersByProjectId/{prId}/{userId}")]
        public async Task<ActionResult<ServiceResponse<List<FounderDTO>>>> GetFoundersByProjectId(int prId,int userId)
        {
            return Ok(await _founderService.GetFoundersByProjectId(prId,userId));
        }
    
        [HttpGet("GetAllFoundersByProjectId/{prId}")]
        public async Task<ActionResult<List<FoundersForProjectDTO>>> GetAllFoundersByProjectId(int prId)
        {
            return Ok(await _founderService.GetAllFoundersByProjectId(prId));
        }
    
        [HttpPost("PostFounder")]
        public async Task<ActionResult<ServiceResponse<bool>>> AddFounder([FromBody]FounderDTO founder)
        {
            return Ok(await _founderService.AddFounder(founder));
        }

         [HttpPost("PostOtherFounder")]
        public async Task<ActionResult<ServiceResponse<bool>>> AddOtherFounders([FromBody]PostOtherFoundersDTO founder)
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