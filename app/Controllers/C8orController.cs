using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using app.DLL.Models;
using app.ModelsDTO;
using app.ModelsDTO.C8or;
using app.Sevices.Abstract;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace app.Controllers
{    
// wch - the following code is needed for authorization  
// ------------------------------------------------------
    [Authorize]
// wch - the previous code is needed for authorization  
// ------------------------------------------------------

    [Route("[controller]")]
    public class C8orController : ControllerBase
    {
        private readonly IC8orService _c8orService;
        public C8orController(IC8orService c8orService)
        {
            _c8orService = c8orService;
        }
           
        [HttpGet("GetAll")]
        public async Task<ActionResult<ServiceResponse<List<Collabor8orDTO>>>> GetAllCollabor8ors()
        {
            return Ok(await _c8orService.GetAllCollabor8ors());
        }
        
        [HttpGet("GetC8orsByUserId/{userId}")]
        public async Task<ActionResult<ServiceResponse<List<Collabor8orDTO>>>> GetC8orsByUserId(int userId)
        {
            return Ok(await _c8orService.GetC8orsByUserId(userId));
        }
        
        [HttpPut("UpdateCollabor8orProfile")]
        public async Task<ActionResult<bool>> UpdateC8or([FromBody]Collabor8orUpdateDTO c8or)
        {
            return Ok(await _c8orService.UpdateC8or(c8or));
        }

        [HttpPost("PostC8or")]
        public async Task<ActionResult<ServiceResponse<bool>>> AddC8or([FromBody]Collabor8orDTO c)
        {
            return Ok(await _c8orService.AddC8or(c));
        }

        [HttpDelete("{userId}/{sphere}")]
        public async Task<ActionResult<bool>> DeleteC8or(int userId,string sphere)
        {
            return Ok(await _c8orService.DeleteC8or(userId,sphere));
        }
      
    }
}