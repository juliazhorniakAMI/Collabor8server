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
    public class C8orAccepted4ProjectController : Controller
    {
       
        private readonly IC8orAccepted4ProjectService _cpService;
        public C8orAccepted4ProjectController(IC8orAccepted4ProjectService cpService)
        {
            _cpService = cpService;
        }

        [HttpPost("AddAcceptedC8or4Pjt")]
        public async Task<ActionResult<bool>> AddAcceptedC8or4Project([FromBody]C8orAccepted4ProjectDTO cp)
        {
            return Ok(await _cpService.AddAcceptedC8or4Project(cp));
        }
        
        [HttpDelete("{id}")]
        public async Task<ActionResult<bool>> CancelAcceptedC8or(int id)
        {
            return Ok(await _cpService.CancelAcceptedC8or(id));
        }

        [HttpGet("GetAcceptedC8rs4MyPrjtsByUserId/{userId}")]
        public async Task<ActionResult<ServiceResponse<List<C8orAccepted4ProjectDTO>>>> GetAcceptedC8rs4MyPrjtsByUserId(int userId)
        {
            return Ok(await _cpService.GetAcceptedC8rs4MyPrjtsByUserId(userId));
        }

        [HttpGet("GetAcceptedMyC8rs4PrjtsByUserId/{userId}")]
        public async Task<ActionResult<ServiceResponse<List<C8orAccepted4ProjectDTO>>>> GetAcceptedMyC8rs4PrjtsByUserId(int userId)
        {
            return Ok(await _cpService.GetAcceptedMyC8rs4PrjtsByUserId(userId));
        }
       
    }
}