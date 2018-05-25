using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace IndividualAccountsDemo.Controllers
{
    public class SecretController : Controller
    {
        [Authorize]
        public ContentResult Secret()
        {
            return Content("This is a secret for authenticated users...");
        }

        // GET: Secret
        public ContentResult Overt()
        {
            return Content("Not a secret...");
        }
    }
}