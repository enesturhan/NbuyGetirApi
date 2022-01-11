using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NbuyGetir.Core.Authorization
{
    /// <summary>
    /// bu servis ile kullanıcının ilgili kaynaga erisimine yetkisi olup olmadıgını kontrol edeceğiz.Claim ve role bazlı kontrolleri icerisinde ypaacagız.
    /// 
    /// </summary>
    public interface IAuthorizationService
    {
        /// <summary>
        /// sistemde oturum acan kullanıcınım sistemdeki özel kaynaklara yetkisi varmı kontrolu yapacağız.Örneğin kargo sorumlusu sadece kargodaki ürünleri görelbilecek.
        /// </summary>
        /// <param name="roleName"></param>
        /// <returns></returns>
        bool HasRole(string roleName);
        bool HasRoles(params string[] roleNames);
        bool HasClaim(string claim);
        /// <summary>
        /// //claims bilgisi kullanıcıya tanımlanmıs olan özellikler örneğin NbuyGetir calısanı mı ,indirim ceki tanımlanmıs mı , indirim kuponu varmı? gibi vs bu kullanıcya tanımlanan extra özelliklere claim diyeceğiz.
        /// </summary>
        /// <param name="claims"></param>
        /// <returns></returns>
        bool HasClaims(params string[] claims); 

    }
}
