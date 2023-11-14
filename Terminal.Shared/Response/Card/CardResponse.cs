using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Terminal.Shared.Response.Card
{
    public class CardResponse
    {
        public Guid Id { get; set; }

        public string Account_db { get; set; } = string.Empty;

        public string Account_cr { get; set; } = string.Empty;

        public int Amount { get; set; }

        public string AboutPay { get; set; } = string.Empty;
        public long Transfer { get; set; }

        public int TerminalId { get; set; }

        public long CardTransferId { get; set; }

        public DateTime DateCreated { get; set; }
        public string acct_1 { get; set; } = string.Empty;

        public string acct_2 { get; set; } = string.Empty;
    }
}
