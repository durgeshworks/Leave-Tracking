using System;
using System.Collections.Generic;

namespace RestBusiness.RestHandlers
{
    public interface IRequestParameters
    {
        Uri BaseAddress { get; set; }
        IEnumerable<KeyValuePair<string, string>> DefaultRequestHeaders { get; set; }
        IEnumerable<KeyValuePair<string, string>> CustomRequestHeaders { get; set; }
    }

}
