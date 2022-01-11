using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NbuyGetir.Core.Security
{
    public interface IDecryptService
    {
        /// <summary>
        /// byte[] olarak sifrelenmis datayı byte [] olarak sifresi cozulmus bir sekilde geriye dondurebiliriz.
        /// </summary>
        /// <param name="chipper"></param>
        /// <returns></returns>
        byte[] Decrypt(byte[] chipper);

    }
}
