using Microsoft.IdentityModel.Tokens;
using System.Text;

namespace Web.Host
{
    public class AuthOptions
    {
        public const string ISSUER = "MyAuthServer123";
        public const string AUDIENCE = "MyAuthClient123";
        public const string KEY = "mysupersecret_secretkey!1231232132131";
        public const int LIFETIME = 72; // hours
        public static SymmetricSecurityKey GetSymmetricSecurityKey()
        {
            return new SymmetricSecurityKey(Encoding.UTF8.GetBytes(KEY));
        }
    }
}
