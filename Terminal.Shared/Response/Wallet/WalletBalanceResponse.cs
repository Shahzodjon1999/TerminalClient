using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Terminal.Shared.Response.Wallet
{
    public class WalletBalanceResponse
    {
        public string Code { get; set; }=string.Empty;

        public string fio { get; set; } = string.Empty;

        public string TransactionNumber { get; set; } = string.Empty;

        public string Comment {  get; set; } = string.Empty;

        public string limit { get; set; }= string.Empty;
    }
}
