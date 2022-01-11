using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NbuyGetir.Core.Authentication
{
    public class TokenClaim
    {
        public string ClaimType { get; set; } //username ,role
        public string ClaimValue { get; set; } //enes , admin

    }
    public class TokenModel
    {
        public string AccessToke { get; set; }
        public DateTime ExpireDate { get; set; }

    }

    public interface ITokenService
    {
        /// <summary>
        /// sisteme giris yapacak kullanıcılar icin erişim bileti access token olusturacağız.
        /// </summary>
        /// <param name="claim"></param>
        /// <returns></returns>
        TokenModel CreateAccessToken(List<TokenClaim> claims);
        /// <summary>
        ///  kullanıcıya ait access token bilgisinin artık kullanılmaması için çalıştıracağımız method .Bu token bilgisi kullanıcıdan geri alıncaktır.
        //Oturum acmak icin bu tokenin bir daha bu kullanıcı tarafından kullanılmaması icin var.
        /// </summary>
        /// <param name="token"></param>
        void RovokeAccessToken(string token);

    }
}
