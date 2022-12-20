using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using app.DLL.Models;
using app.ModelsDTO;
using app.Sevices.Abstract;
using Microsoft.AspNetCore.Mvc;

namespace app.Controllers
{
    [Route("[controller]")]
    public class C8orController : ControllerBase
    {
        private readonly IC8orService _c8orService;
        public C8orController(IC8orService c8orService)
        {
            _c8orService = c8orService;
        }
        
        [HttpGet("{id}",Name ="GetCollabor8orProfile")]
        public async Task<ActionResult<ServiceResponse<List<Collabor8orDTO>>>> GetC8orsByUserId(int id)
        {
            return Ok(await _c8orService.GetC8orsByUserId(id));
        }
        
        [HttpPut("UpdateCollabor8orProfile")]
        public async Task<ActionResult<bool>> UpdateC8or([FromBody]Collabor8orDTO c8or)
        {
            return Ok(await _c8orService.UpdateC8or(c8or));
        }

        [HttpPost("{userId}")]
        public async Task<ActionResult<bool>> AddC8or(int userId)
        {
            return Ok(await _c8orService.AddC8or(userId));
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult<bool>> DeleteC8or(int id)
        {
            return Ok(await _c8orService.DeleteC8or(id));
        }
      
    }
}