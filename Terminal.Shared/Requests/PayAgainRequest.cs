using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Terminal.Shared.Requests
{
    public class PayAgainRequest
    {
        public long DcTransferId { get; set; }

        public long TransferId { get; set; }

        public string Account { get; set; } = string.Empty;

        public int TerminalId { get; set; }

        public double Amount { get; set; }

        public int Provider { get; set; }
    }
}
