using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ErpCore.Business.Logic.Dtos
{
    public class TokenModel
    {
        public string? accessToken { get; set; }
        public string? refreshToken { get; set; }
    }
}
