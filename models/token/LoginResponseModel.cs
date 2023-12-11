using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PayCore.Client.models.token
{
    public class LoginResponseModel
    {
        public string accessToken { get; set; }
        public DateTime expireDate { get; set; }
    }
}
