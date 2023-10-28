using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Terminal.Shared.Response.Wallet
{
    public class ResponseWalletPay
    { 
        public string amt { get; set; } = string.Empty;

        public string txt_id { get; set; } = string.Empty;

        public string acct { get; set; } = string.Empty;

        public string created_at { get; set; } = string.Empty;
    }
}
