using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Terminal.Shared.Response.DcResponse
{
    public class DcStatusResponses
    {
        public IEnumerable<DcStatusResponse> StatusResponses { get; set; }=Enumerable.Empty<DcStatusResponse>();
    }
}
