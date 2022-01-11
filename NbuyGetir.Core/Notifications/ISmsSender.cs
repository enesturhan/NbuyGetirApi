using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NbuyGetir.Core.Notifications
{
    public interface ISmsSender
    {
      /// <summary>
      /// hangi telefon numarasına hangi mesajı atacagımızı bu servis ile yapacagız Twilio diye bir paket kullanacağız.
     /// </summary>
      /// <param name="phoneNumber"></param>
      /// <param name="message"></param>
      /// <returns></returns>
        Task SendSmsAsync(string phoneNumber,string message);

    }
}
