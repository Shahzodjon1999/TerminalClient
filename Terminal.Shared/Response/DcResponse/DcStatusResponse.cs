using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Terminal.Shared.Response.DcResponse
{
    public class DcStatusResponse
    {
        public double Amount { get; set; }

        public long TransferId { get; set; }

        public string Account { get; set; }

        public long DcTransferId { get; set; }

        public int TerminalId { get; set; }

        public int Provider { get; set; }

        public DateTime DateTimeSave { get; set; }

        public string Error_massage { get; set; }

        public string name_provider { get; set; }
    }
}
