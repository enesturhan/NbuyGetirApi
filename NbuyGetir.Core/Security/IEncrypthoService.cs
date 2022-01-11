using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NbuyGetir.Core.Security
{
    public interface IEncrypthoService
    {
        /// <summary>
        /// MD5 ile veya SHA,DES,JDES gibi algoritmalar ile sifreleme işlemleri yapan bir servis olarak kullanılabilir. MD5 algoritmasıgeriyi cevrilemez.
        /// </summary>
        /// <param name="plainText"></param>
        /// <returns></returns>
        string Encrypt(string plainText);

    }
}
