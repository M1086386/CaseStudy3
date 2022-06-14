using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web.Http;
using CaseStudy3.Models;

namespace CaseStudy3.Controllers
{
    public class SchoolController : ApiController
    {
        List<School> schools = new List<School>();

        public SchoolController() { }

        public SchoolController(List<School> schools)
        {
            this.schools = schools;
        }

        public IEnumerable<School> GetAllSchools()
        {
            return schools;
        }

        public IHttpActionResult GetSchool(int id)
        {
            var school = schools.FirstOrDefault((s) => s.SchoolIdentity == id);
            if (school == null)
            {
                return NotFound();
            }
            return Ok(school);
        }

        public async Task<IHttpActionResult> GetProductAsync(int id)
        {
            return await Task.FromResult(GetSchool(id));
        }

    }
}
