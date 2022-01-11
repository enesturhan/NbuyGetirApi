using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NbuyGetir.Core.Authentication
{
    public class AuthenticationError
    {
        public string Code { get; set; } //202 user not found
        public string Message { get; set; } //boyle bir kullanıcı sistemde bulunamadı.
        public string Key { get; set; } //username

    }
    public class AuthentaticationResult
    {
        public bool IsSucceded { get; private set; } = true;
        public string AccessToken { get; private set; }

        public List<AuthenticationError> Errors { get; private set; }
        
        void AddError(AuthenticationError error)
        {
            IsSucceded = false;
            Errors.Add(error);

        }
        public void SetAccessToken(string token)
        {
            if (IsSucceded)
            {
                AccessToken = token;

            }
           
        }
    }
    public interface IAuthenticationService
    {
        /// <summary>
        /// login olduktan sonra remember me true olursa bu token 1 aylık bitr token olsun.Diğer türlü 1 günlük token olusturacağız.
        /// jws json web token
        /// </summary>
        /// <param name="email"></param>
        /// <param name="password"></param>
        /// <param name="rememberme"></param>
        /// <returns></returns>
        AuthentaticationResult Login(string email, string password, bool rememberme);
        void Logout(string accessToken); //kullanıcıya giris islemleri icin verilen accessToken expire edeceğiz.artık bu access token gecersiz olacak kullanıcın sistemden güvenli cıkısı icin var.



    }
}
