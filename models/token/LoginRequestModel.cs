using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PayCore.Client.models.token
{
    public class LoginRequestModel
    {
        public string EMail { get; set; }
        public string Password { get; set; }
    }
}
