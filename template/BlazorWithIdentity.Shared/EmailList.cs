using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlazorWithIdentity.Shared
{
    public class InboxEmail
    {
        public string Subject { get; set; }
        public string Sender { get; set; }
        public DateTime Date { get; set; }
    }
}
