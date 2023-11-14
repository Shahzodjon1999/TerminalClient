using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Terminal.Shared.Response.Wallet
{
    public class WalletResponse
    {
        public Guid Id { get; set; }

        public string Account_db { get; set; } = string.Empty;

        public string Account_cr { get; set; } = string.Empty;

        public double Amount { get; set; }

        public long Transfer { get; set; }

        public long Account { get; set; }

        public string AboutPay { get; set; } = string.Empty;

        public int TerminalId { get; set; }

        public long WalletTransferId { get; set; }

        public DateTime DateCreated { get; set; }
        public string acct_1 { get; set; } = string.Empty;

        public string acct_2 { get; set; } = string.Empty;
    }
}
