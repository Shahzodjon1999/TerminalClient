using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Terminal.Shared.Response.Wallet
{
    public class WalletResponses
    {
        public IEnumerable<WalletResponse> WalletEnumrables { get; set; }=Enumerable.Empty<WalletResponse>();
    }
}
