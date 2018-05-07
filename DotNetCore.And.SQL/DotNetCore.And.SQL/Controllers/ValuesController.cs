using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace DotNetCore.And.SQL.Controllers
{
    [Route("api/[controller]")]
    public class ValuesController : Controller
    {
        public ApplicationDBContext DbContext { get; }

        public ValuesController(ApplicationDBContext dbContext)
        {
            DbContext = dbContext;
        }

        // GET api/values
        [HttpGet]
        public IEnumerable<string> Get()
        {
            var user = DbContext.Users.FirstOrDefault();

            return new string[] { user.ID.ToString(), user.FirstMidName };
        }
    }
}
