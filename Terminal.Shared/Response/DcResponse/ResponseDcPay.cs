using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Terminal.Shared.Response.DcResponse
{
    public  class ResponseDcPay
    {
        public string error_code { get; set; } = string.Empty;

        public string prvid { get; set; } = string.Empty;

        public string amt { get; set; }= string.Empty;

        public string txt_id { get; set; } = string.Empty;

        public string term_id { get; set; } = string.Empty;

        public string acct { get; set; } = string.Empty;

        public string created_at { get; set; }=string.Empty;
    }
}
