using System;
using System.Collections.Generic;

namespace RestBusiness.RestHandlers
{
    public class RequestParameters : IRequestParameters
    {
        public Uri BaseAddress { get; set; }
        public IEnumerable<KeyValuePair<string, string>> DefaultRequestHeaders { get; set; }
        public IEnumerable<KeyValuePair<string, string>> CustomRequestHeaders { get; set; }
       
    }
}
