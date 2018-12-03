using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Todana.Controllers
{
    public class ErrorController : ApiController
    {
        public string Get()
        {
            return "GET Success!!";
        }
    }
}
