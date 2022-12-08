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
    [ApiController]
    [Route("api/[controller]")]
    public class C8orController : ControllerBase
    {
        private readonly IC8orService _c8orService;
        public C8orController(IC8orService c8orService)
        {
            _c8orService = c8orService;
        }
        
        [HttpGet("{id}",Name ="GetCollabor8orProfile")]
       
        public async Task<ActionResult<ServiceResponse<Collabor8orDTO>>> GetC8or(int id)
        {
            return Ok(await _c8orService.GetC8orByUserId(id));
        }
        [HttpPut("{id}",Name ="UpdateCollabor8orProfile")]
        public async Task<ActionResult<bool>> UpdateC8or([FromBody]Collabor8orDTO c8or,int id)
        {
            return Ok(await _c8orService.UpdateC8or(c8or,id));
        }

      
    }
}