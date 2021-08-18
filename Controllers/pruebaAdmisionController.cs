using ApiPrueba.Context;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ApiPrueba.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class pruebaAdmisionController : ControllerBase
    {
        private readonly AppDbContext context;

        public pruebaAdmisionController(AppDbContext context)
        {
            this.context = context;
        }
        // GET: api/<ValuesController>
        [HttpGet]
        public ActionResult Get()
        {
            try
            {
                return Ok(context.prueba_admision.ToList());
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }

        }

        // GET api/<ValuesController>/5
        [HttpGet("{id}", Name = "GetHistory")]
        public ActionResult Get(int id)
        {
            try
            {

                var history = context.prueba_admision.FirstOrDefault(g => g.id == id);
                return Ok(history);

            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
    }
}
}
