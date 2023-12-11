using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PayCore.Client.models.general
{
    public class ResponseModel<T>
    {
        public int StatusCode { get; set; }
        public string ErrorMessage { get; set; } = string.Empty;
        public T Data { get; set; }

        public bool IsSuccess { get; set; }


    }
}
