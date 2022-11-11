using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using WebApplicationRUAP_2.Models;

namespace WebApplicationRUAP_2.Controllers
{
    public class ContactController : ApiController
    {
        public Contact[] Get()
        {
            return new Contact[]
            {
        new Contact
        {
            Id = 1,
            Name = "Glenn Block"
        },
        new Contact
        {
            Id = 2,
            Name = "Dan Roth"
        }
            };
        }
    }
}
