using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Terminal.Shared.Response.Amonat
{
    public class AmonatResponse
    {
        public Guid Id { get; set; }

        public string Account_db { get; set; } = string.Empty;

        public string Account_cr { get; set; } = string.Empty;

        public string Account { get; set; } = string.Empty;

        public double Amount { get; set; }

        public long Transfer { get; set; }

        public string AboutPay { get; set; } = string.Empty;

        public int TerminalId { get; set; }

        public long AmonatTransferId { get; set; }

        public DateTime DateCreated { get; set; }
    }
}
