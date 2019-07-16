using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using GenericAdapter.Services.AdapterServices;
using Microsoft.AspNetCore.Mvc;

namespace GenericAdapter.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ValuesController : ControllerBase
    {
        public IAdapterService _service;
        public ValuesController(IAdapterService service)
        {
            this._service = service;
        }
        // GET api/values
        [HttpGet]
        [Route("api/getMerchant/{id}")]
        public async Task<string> getMerchant(int id)
        {
            var serviceName = "SingleUser";
            var response = string.Empty;
            try
            {
                response = await _service.GetPayload(id, serviceName);

            }
            catch (Exception ex)
            {
                //logger here
                throw ex;
            }

            return response;
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public ActionResult<string> Get(int id)
        {
            return "value";
        }

        // POST api/values
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
