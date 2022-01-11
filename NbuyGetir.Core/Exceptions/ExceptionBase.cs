using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NbuyGetir.Core.Exceptions
{
    public static class ExceptionCodes
    {
        public const string UserNotFound = "1001";
        public const string OrderRejected = "2001";
        public const string AccountDenied = "3001";
    }

    /// <summary>
    /// uyugulama icerisinde logic kaynaklı hatları fırlatmak icin bu sınıfı kullancagız
    /// uyuglama icerisinde olukcak hatalrı exception olarak birer kod veriyoruz
    /// Hata mesahı ile hangi kodu aldgımıza dair bilgileri bu sınıftan kalıtım alan sınıflara vercegiz
    /// boylelikle uygulamada olusan hatalrı daha kolay loglayabileceğiz
    /// Exception sınıfı ana hata sınıfı olup knedi uygulama hata sınıfılarımızıa olusturacağız.
    /// 
    /// </summary>
    public abstract class ExceptionBase : Exception
    {
        public string ErrorCode { get;private set; }

        /// <summary>
        /// bir hata durumunda hata ile ilgili bir class acıp mesaj ve errorCode bilgisini constructor ile belirtiryoruz.
        /// </summary>
        /// <param name="message"></param>
        /// <param name="errorCode"></param>
        public ExceptionBase(string message, string errorCode) : base(message)
        {

            ErrorCode = errorCode;
        }
    }
}
   
