using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace NbuyGetir.Core.Sessions
{
    //sepet ile ilgili bilgileri



    /// <summary>
    /// kullanıya ait sepet bilgileri siparis islemleri sırasında sessionda saklancak bunun gibi oturum bazlı veri saklama durumlarımız icin bu servisi kullanacagız
    /// </summary>
    public interface ISessionService<TObject> where TObject:class
    {
        void Add(TObject @object, string key);//key value cinsinden ramde oturum bilgisini object olarak tutmak icin kullanıcagız
        void Remove(string key);//ilgili session bilgisini ramden kaldırmak icin kullanıcaz.

        /// <summary>
        /// remove oturum bazlı saklanan değer
        /// </summary>
        TObject GetSession(string key);

    }
}
