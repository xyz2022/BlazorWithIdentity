using BlazorWithIdentity.Shared;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorWithIdentity.Server.Controllers
{
    [Route("api/[controller]")]
    [Authorize]
    public class EmailController : Controller
    {
        private static string[] Summaries2 = new[]
        {
            "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
        };

        [HttpGet("[action]")]
        public IEnumerable<InboxEmail> InboxEmails()
        {
            var rng = new Random();
            return Enumerable.Range(1, 5).Select(index => new InboxEmail
            {
                Subject = "Test Subject",
                Sender = "Test Sender",
                Date = DateTime.Now.AddDays(index)

            });
        }
    }
}
