using Newtonsoft.Json;
using Oxiyopal.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Oxiyopal.Services.ModelServices
{
    class CilindroSearchResult
    {
        [JsonIgnore]
        private readonly Cilindro _cilindro;

        public CilindroSearchResult(Cilindro cilindro)
        {
            this._cilindro = cilindro;
        }
    }
}
