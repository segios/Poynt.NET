using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Poynt.NET.Model
{
    public class TokenResponse
    {
        public string TokenType { get; set; }
        public int ExpiresIn { get; set; }
        public string Scope { get; set; }
        public string RefreshToken { get; set; }
        public string AccessToken { get; set; }
    }

}
