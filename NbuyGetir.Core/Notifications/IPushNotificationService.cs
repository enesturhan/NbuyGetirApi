using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NbuyGetir.Core.Notifications
{
   public interface IPushNotificationService
    {
        /// <summary>
        /// mobil uygulamayı bir kullancı user hesabında deviceıd sini tutacağız.One signal ile kişinin cihazına bildirim göndereceğiz.
        /// appıd mobil uygulamaya indiren kullanıcıya one signal tarafından verilen ıd . bu id değerini user tablosunda tutacagız ve bildirim gönderirken bu id değerine göre bildirim göndereceğiz.
        /// </summary>
        /// <param name="appId"></param>
        /// <param name="message"></param>
        /// <returns></returns>
        Task SendPushNotificationAsync(string appId, string message);

    }
}
