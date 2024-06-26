using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Auth
{
    public class JwtOptions
    {
        public string? Secret { get; set; }
        public int ExpireTime { get; set; }
        public string? Issuer { get; set; }
    }
}
