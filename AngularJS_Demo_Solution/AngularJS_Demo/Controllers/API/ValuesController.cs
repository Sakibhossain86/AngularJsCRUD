using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace AngularJS_Demo.Controllers.API
{
    public class ValuesController : ApiController
    {
        // GET: api/Values
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET: api/Values/5
        [HttpGet]
        [Route("thana/{district}")]
        public string[] Get( string district)
        {
            if (district == "Dhaka")
            {
                return new string[] { "Kafrul", "Mirpur", "Dhanmondi", "Gulshan", "Mohammadpur" };
            }
            else if(district == "Chittagong")
            {
                return new string[] { "Akbarshah", "Bakilia", "Bandar", "EPZ", "Dabolmuring" };
            }
            else if (district == "Rajshahi")
            {
                return new string[] { "Bagmara", "Charghat", "Godagari", "Mohanpur" };
            }
            else
            {
                return new string[] { };
            }
        }

        // POST: api/Values
        public void Post([FromBody]string value)
        {
        }

        // PUT: api/Values/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/Values/5
        public void Delete(int id)
        {
        }
    }
}
